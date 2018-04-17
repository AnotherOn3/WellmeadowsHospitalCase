using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.Models
{
    public class Bed
    {
        public int Id { get; set; }
        public int BedNumber { get; set; }
        public bool IsAvailable { get; set; }
        public int WardId { get; set; }
    }
}