using BusinessLayer.ViewModels.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public interface IDoctorManager
    {
        List<DoctorReadVm> GetAllDoctors();
        DoctorReadVm? GetById(Guid id);
        DoctorReadVm Add(DoctorAddVm model);
        bool Update (DoctorUpdateVm model);
        void Delete (Guid id);
    }
}
