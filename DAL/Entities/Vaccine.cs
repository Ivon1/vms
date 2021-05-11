﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Vaccine
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; } 
        public virtual Country Country { get; set; }

        public virtual List<Journal> Records { get; set; }
    }
}
