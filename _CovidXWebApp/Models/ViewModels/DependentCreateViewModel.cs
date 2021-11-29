using EFCORE_DATAACCESS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static EFCORE_DATAACCESS.Models.CovidEnums;

namespace _CovidXWebApp.Models.ViewModels
{
    public class DependentCreateViewModel
    {

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "ID Number is required")]
        [RegularExpression(@"[0-9]{13}", ErrorMessage = "Invalid ID Number")]
        [StringLength(13, ErrorMessage = "ID number must be 13 characters")]
        public string Idnumber { get; set; }

        [Required(ErrorMessage = "Person Responsible is required")]
        public string PersonResponsible { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string EmailAddress { get; set; }
 
      

        [Required(ErrorMessage = "Mobile Number is required")]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Invalid Mobile Number")]
        [StringLength(10, ErrorMessage = "Mobile number must be 10 digits")]
        public string MobileNumber { get; set; }

        public bool AddressSameasMainMember { get; set; } = false;
        public bool MedicalAidSameasMainMember { get; set; } 
        public string AddressLine1 { get; set; }

        #nullable enable
        public string? AddressLine2 { get; set; }

   
        public int? SuburbId { get; set; }
        [Required]
        public DateTime Dob { get; set; }

        [Required]
        public Gender Gender { get; set; }
        [Required]
        public bool MedicalAidStatus { get; set; }

        
        public string? MedicalAidNo { get; set; }
        public int? MedicalAidPlanId { get; set; }
        [Required(ErrorMessage = "Dependent type is required")]
        public int DependentTypeId { get; set; }

        #nullable enable
        public string? DependencyCode { get; set; }

        //PatientID
        public int MainMemberId { get; set; }

        //public Patient patientByUserId { get; set; }
    }
}
