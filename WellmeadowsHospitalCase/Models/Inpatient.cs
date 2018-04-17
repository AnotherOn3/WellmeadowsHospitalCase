using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.Models
{
    public class Inpatient
    {
        public int Id { get; set; }
        public int BedId { get; set; }
        public int PatientId { get; set; }
        public int ExpectedStay { get; set; }
        public DateTime DatePlaced { get; set; }
        public DateTime ExpectedDateLeave { get; set; }
        public DateTime ActualLeave { get; set; }
    }
}