using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.ViewModels
{
    public class EmployeeContractVM
    {
        public int Id { get; set; }
        public float Salary { get; set; }
        public int WorkingHours { get; set; }
        public string TypeOfContract { get; set; }
        public string TypeOfPayment { get; set; }
        public string SalaryScale { get; set; }
    }
}