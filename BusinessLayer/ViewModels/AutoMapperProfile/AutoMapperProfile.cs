using AutoMapper;
using BusinessLayer.ViewModels.Doctor;
using day2withDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<day2withDB.Data.Models.Doctor, DoctorReadVm>();
            CreateMap<DoctorUpdateVm, day2withDB.Data.Models.Doctor>();
            CreateMap<DoctorAddVm, day2withDB.Data.Models.Doctor>();
        }
    }
}
