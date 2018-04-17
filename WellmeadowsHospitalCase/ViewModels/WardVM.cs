using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.ViewModels
{
    public class WardVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int NumberOfBeds { get; set; }
        public string TelExtentionNumber { get; set; }
    }
}