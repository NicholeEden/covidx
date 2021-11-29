using EFCORE_DATAACCESS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static EFCORE_DATAACCESS.Models.CovidEnums;

namespace _CovidXWebApp.Models.ViewModels
{
    public class PatientEditViewModel
    {
        public int PatientId { get; set; }
        public string UserID { get; set; }
       
        public string FirstName { get; set; }
   
        public string LastName { get; set; }

        [MaxLength(13, ErrorMessage = "ID needs to be 13 digits")]
        public string Idnumber { get; set; }
        //public string EmailAddress { get; set; }

        [ MaxLength(10, ErrorMessage = "Mobile needs to be 10 digits")]
        public string MobileNumber { get; set; }
      
        public int SuburbId { get; set; }
     
        public DateTime Dob { get; set; }
    
        public string AddressLine1 { get; set; }
#nullable enable
        public string? AddressLine2 { get; set; }
        [Required]
        public bool MedicalAidStatus { get; set; } = false;

#nullable enable
        public int? MedicalAidPlanId { get; set; }

#nullable enable

        public string? MedicalAidNo { get; set; }
#nullable enable
        public string? DependencyCode { get; set; }

  
        public Gender Gender { get; set; }

    }
}
