using EFCORE_DATAACCESS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static EFCORE_DATAACCESS.Models.CovidEnums;

namespace _CovidXWebApp.Models
{
    public class PatientCreateViewModel
    {
        //public Patient Patient { get; set; }
        //public int PatientId { get; set; }
        public string UserID { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

       
        [Required(ErrorMessage ="ID Number is required")]
        [RegularExpression(@"[0-9]{13}", ErrorMessage = "Invalid ID Number")]
        [StringLength(13, ErrorMessage = "ID number must be 13 characters")]
        public string Idnumber { get; set; }
        //public string EmailAddress { get; set; }

       
        [Required(ErrorMessage = "Mobile Number is required")]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Invalid Mobile Number")]
        [StringLength(10, ErrorMessage = "Mobile number must be 10 digits")]

        public string MobileNumber { get; set; }
        [Required]
        public int SuburbId { get; set; }
        [Required]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Person responsible is Required")]
        public string PersonResponsible  { get; set; }

        [Required(ErrorMessage ="Address is Required")]
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

        [Required(ErrorMessage = "Gender is required")]
        public Gender Gender { get; set; }


    }
}
