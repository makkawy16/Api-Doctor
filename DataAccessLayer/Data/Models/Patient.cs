using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Issue> Issues { get; set; }
    }
}
