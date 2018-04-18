using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime RegisterDate { get; set; }
        public int NextOfKinId { get; set; }
        public int LocalDoctorId { get; set; }
        public bool IsOutpatient { get; set; }
    }
}