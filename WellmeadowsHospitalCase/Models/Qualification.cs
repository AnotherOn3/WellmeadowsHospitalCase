﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.Models
{
    public class Qualification
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string InstitutionName { get; set; }
        public int StaffId { get; set; }

    }
}