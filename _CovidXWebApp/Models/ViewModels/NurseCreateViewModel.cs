using EFCORE_DATAACCESS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static EFCORE_DATAACCESS.Models.CovidEnums;

namespace _CovidXWebApp.Models
{
    public class NurseCreateViewModel
    {

        [Required (ErrorMessage ="Id is required")]
        public string Idnumber { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Mobile is required")]
        public string MobileNumber { get; set; }

      

        [Required(ErrorMessage = "Residential Suburb is required")]
        public int SuburbId { get; set; }

        [Required(ErrorMessage = "Year qualified is required")]
        public DateTime YearQualified { get; set; }

        [Required(ErrorMessage = "Rank is required")]
        public Rank Rank { get; set; }

    


    }
}
