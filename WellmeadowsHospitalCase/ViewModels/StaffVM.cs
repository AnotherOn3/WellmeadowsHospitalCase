using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.ViewModels
{
    public class StaffVM
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int StaffNumber { get; set; }
        public string TypeOfShift { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Insurance { get; set; }
        public int ContractId { get; set; }
        public int PositionId { get; set; }
        public int WardId { get; set; }

        public PositionVM Position { get; set; }
        public List<AppointmentVM> Appointments { get; set; }
        public EmployeeContractVM EmployeeContract { get; set; }
        public List<ExperienceVM> Experiences { get; set; }
        public List<QualificationVM> Qualifications { get; set; }
        public WardVM Ward { get; set; }
    }
}