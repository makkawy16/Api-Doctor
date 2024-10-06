using AutoMapper;
using BusinessLayer.Manager;
using BusinessLayer.ViewModels.Doctor;
using Microsoft.AspNetCore.Mvc;

namespace day2withDB.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class DoctorsController : ControllerBase
    {
        IDoctorManager doctorManager;
        

        public DoctorsController(IDoctorManager doctorManager )
        {
            this.doctorManager = doctorManager;
           
        }

        [HttpGet]
        public ActionResult<List<DoctorReadVm>> GetAllDoctors()
        {
            return doctorManager.GetAllDoctors();
        } 
        
        [HttpGet("{id}")] // like  Route("{id}") 
        public ActionResult<DoctorReadVm> GetDoctorById(Guid id)
        {
            var doctor = doctorManager.GetById(id);
            if (doctor == null) 
                return NotFound();
            return Ok(doctor);  
        }
        [HttpPost]
        public ActionResult<DoctorReadVm> AddDoctor(DoctorAddVm model)
        {
            var doctor = doctorManager.Add(model);

            return CreatedAtAction("GetDoctorById" , new {id = doctor.Id} , doctor );
        }

        [HttpPut("{id}")]
        public ActionResult UpdateDoctor(Guid id , DoctorUpdateVm model)
        {
            if(id != model.Id)
                return BadRequest();

            var result = doctorManager.Update(model);
            if(result)
                return NoContent();
            return NotFound();
        }

        [HttpDelete("id")]
        public ActionResult DeleteDoctor(Guid id) 
        {
            doctorManager.Delete(id);  
            return NoContent();
        
        }
    }
}
