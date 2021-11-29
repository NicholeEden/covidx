using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EFCORE_DATAACCESS.Models.CovidEnums;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Dependents = new HashSet<Dependent>();
            TestRequests = new HashSet<TestRequest>();
        }

        public int PatientId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required,MaxLength(13)]
        public string Idnumber { get; set; }
        //public string EmailAddress { get; set; }

        [Required, MaxLength(10)]
        public string MobileNumber { get; set; }
        [Required]
        public int SuburbId { get; set; }
        [Required]
        public DateTime Dob { get; set; }

        [Required]
        public string PersonResponsible { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
         #nullable enable
        public string? AddressLine2 { get; set; }
        [Required]
        public bool MedicalAidStatus { get; set; } 

        
        #nullable enable
        public int? MedicalAidPlanId { get; set; }

        #nullable enable
        
        public string? MedicalAidNo { get; set; }
        #nullable enable
        public string? DependencyCode { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [ForeignKey(nameof(MedicalAidPlanId))]
        public virtual MedicalAidPlan? MedicalAidPlan { get; set; }

        [Required]
        [ForeignKey(nameof(CovidXUser))]
        public string UserID { get; set; }

        [ForeignKey(nameof(SuburbId))]
        public virtual Suburb Suburb { get; set; }
        public virtual ICollection<Dependent> Dependents { get; set; }
        public virtual ICollection<TestRequest> TestRequests { get; set; }
    }
}
