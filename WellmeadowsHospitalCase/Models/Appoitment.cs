using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.Models
{
    public class Appoitment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsOnWaitingList { get; set; }
        public string ExaminationRoom { get; set; }
        public int StaffId { get; set; }
        public int PatientId { get; set; }
    }
}