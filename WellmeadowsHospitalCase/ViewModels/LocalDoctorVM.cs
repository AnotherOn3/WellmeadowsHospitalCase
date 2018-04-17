using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.ViewModels
{
    public class LocalDoctorVM
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ClinicNumber { get; set; }

        public List<PatientVM> Patients { get; set; }
    }
}