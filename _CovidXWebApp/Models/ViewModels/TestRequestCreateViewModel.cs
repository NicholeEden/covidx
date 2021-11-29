using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static EFCORE_DATAACCESS.Models.CovidEnums;

namespace _CovidXWebApp.Models.ViewModels
{
    public class TestRequestCreateViewModel
    {
        public int[] SelectedDependentIds { get; set; }
        // public string SuburbName { get; set; }
        public bool testforMyself { get; set; }
        public bool TestAddressSameasMainMember { get; set; }
        [Required]
        public int PatientId { get; set; }
#nullable enable
        public int? DependentId { get; set; }
        [Required]
        public DateTime RequestDate { get; set; }
        

        [Required]
        public string?TestAddress1 { get; set; }
       #nullable enable
        public string? TestAddress2 { get; set; }
        [Required]
        public int SuburbId { get; set; }

       
    }
}
