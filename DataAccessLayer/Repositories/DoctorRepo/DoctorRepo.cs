using DataAccessLayer.Repositories.GenericRepo;
using day2withDB.Data.Context.DAL;
using day2withDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.DoctorRepo
{
    public class DoctorRepo : GenericRepo<Doctor>, IDoctorRepo
    {
        private readonly WebAppContext webAppContext;

        public DoctorRepo(WebAppContext webAppContext) : base(webAppContext)
        {
            this.webAppContext = webAppContext;
        }

        public List<Doctor> GetDoctorsByRate(int rate)
        {
            return webAppContext.Set<Doctor>().Where(x=> x.PerformanceRate > rate).ToList();
        }
    }
}
