﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Models
{
    
    public class Student
    {
       
        public int SId { get; set; }
        public string SName { get; set; }
        public DateTime SDob { get; set; }
        public string SContact { get; set; }
    }
}
