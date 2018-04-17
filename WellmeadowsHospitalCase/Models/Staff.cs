using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.Models
{
    public class Staff
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
    }
}