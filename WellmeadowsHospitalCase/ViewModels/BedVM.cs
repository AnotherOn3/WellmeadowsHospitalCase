using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.ViewModels
{
    public class BedVM
    {
        public int Id { get; set; }
        public int BedNumber { get; set; }
        public bool IsAvailable { get; set; }
        public int WardId { get; set; }

        public List<InpatientVM> Inpatients { get; set; }
        public WardVM Ward { get; set; }
    }
}