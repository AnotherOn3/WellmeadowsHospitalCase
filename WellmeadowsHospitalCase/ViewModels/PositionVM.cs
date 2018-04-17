using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.ViewModels
{
    public class PositionVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<StaffVM> Staffs { get; set; }
    }
}