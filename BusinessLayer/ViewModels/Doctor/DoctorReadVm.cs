using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels.Doctor
{
    public class DoctorReadVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

    }
}
