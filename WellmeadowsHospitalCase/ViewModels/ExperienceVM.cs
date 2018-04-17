using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.ViewModels
{
    public class ExperienceVM
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Position { get; set; }
        public string OrganisationName { get; set; }
        public int StaffId { get; set; }

        public StaffVM Staff { get; set; }
    }
}