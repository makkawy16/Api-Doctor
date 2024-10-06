﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.Models
{
    public class Issue
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
