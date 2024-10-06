using DataAccessLayer.Repositories.GenericRepo;
using day2withDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.DoctorRepo
{
    public interface IDoctorRepo : IGenericRepo<Doctor>
    {
        List<Doctor> GetDoctorsByRate(int rate);
    }
}
