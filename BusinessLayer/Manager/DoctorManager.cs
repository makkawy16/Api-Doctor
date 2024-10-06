using AutoMapper;
using BusinessLayer.ViewModels.Doctor;
using DataAccessLayer.Repositories.DoctorRepo;
using day2withDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class DoctorManager : IDoctorManager
    {

        private readonly IDoctorRepo doctorRepo;
        private readonly IMapper mapper;

        public DoctorManager(IDoctorRepo doctorRepo, IMapper mapper)
        {
            this.doctorRepo = doctorRepo;
            this.mapper = mapper;
        }

        public List<DoctorReadVm> GetAllDoctors()
        {
            var docs = doctorRepo.GetAll();

            return  mapper.Map<List<DoctorReadVm>>(docs);

            //return docs.Select(x => new DoctorReadVm()
            //{
            //    Name = x.Name,
            //    Specialization = x.Specialization

            //}).ToList();
        }

        public DoctorReadVm Add(DoctorAddVm model)
        {
            var dbdoctor = mapper.Map<Doctor>(model);
            dbdoctor.Id = Guid.NewGuid();
            doctorRepo.Add(dbdoctor);
            doctorRepo.SaveChanges();
            return mapper.Map<DoctorReadVm>(dbdoctor);
        }

        public void Delete(Guid id)
        {
            //var dbDoctor = doctorRepo.GetById(id);

            //if (dbDoctor is null)
            //    return ;
            //doctorRepo.Delete(dbDoctor);
            doctorRepo.DeleteById(id);
            doctorRepo.SaveChanges();
        }

      

        public DoctorReadVm? GetById(Guid id)
        {
            var dbDoctor = doctorRepo.GetById (id);

            if (dbDoctor is null)
                return null;
            return mapper.Map<DoctorReadVm>(dbDoctor);
                
            
        }

        public bool Update(DoctorUpdateVm model)
        {
            var dbdoctor = doctorRepo.GetById(model.Id);
            if(dbdoctor is null)  
                return false;
            mapper.Map(model, dbdoctor);
            doctorRepo.Update(dbdoctor);
            doctorRepo.SaveChanges();
            return true;
        }
    }
}
