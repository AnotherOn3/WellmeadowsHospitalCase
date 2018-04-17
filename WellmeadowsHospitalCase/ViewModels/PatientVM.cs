using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.ViewModels
{
    public class PatientVM
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string MartialStatus { get; set; }
        public DateTime RegisterDate { get; set; }
        public int NextOfKinId { get; set; }
        public int LocalDoctorId { get; set; }
        public bool IsOutpatient { get; set; }

        public List<AppointmentVM> Appointments { get; set; }
        public List<InpatientVM> Inpatients { get; set; }
        public LocalDoctorVM LocalDoctor { get; set; }
        public NextOfKinVM NextOfKin { get; set; }
    }
}