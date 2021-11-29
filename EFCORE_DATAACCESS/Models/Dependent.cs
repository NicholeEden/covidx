using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using static EFCORE_DATAACCESS.Models.CovidEnums;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    [Table(name: "Dependent")]
    public partial class Dependent
    {
        public Dependent()
        {
            TestRequests = new HashSet<TestRequest>();
        }

        public int DependentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required, MaxLength(13)]
        public string Idnumber { get; set; }

        public string EmailAddress { get; set; }

        [Required, MaxLength(10)]
        public string MobileNumber { get; set; }

  #nullable enable
        public string? AddressLine1 { get; set; }

#nullable enable
        public string? AddressLine2 { get; set; }

        #nullable enable
        public int? SuburbId { get; set; }

       #nullable enable
        public string? PersonResponsible { get; set; }

        [Required]
        public DateTime Dob { get; set; }

      #nullable enable

        public string? MedicalAidNo { get; set; }

       

        [Required]
        public bool MedicalAidStatus { get; set; }

        [Required]
        public int DependentTypeId { get; set; }

#nullable enable
        public string? DependencyCode { get; set; }

#nullable enable
        public int? MedicalAidPlanId { get; set; }

        public int MainMemberId { get; set; }


        [Required]
        public Gender Gender { get; set; }

        [ForeignKey(nameof(DependentTypeId))]
        public virtual DependentType DependentType { get; set; }

        [ForeignKey(nameof(MainMemberId))]
        public virtual Patient MainMember { get; set; }

        [ForeignKey(nameof(MedicalAidPlanId))]
        public virtual MedicalAidPlan? MedicalAidPlan { get; set; }

        [ForeignKey(nameof(SuburbId))]
        public virtual Suburb Suburb { get; set; }

        public virtual ICollection<TestRequest> TestRequests { get; set; }
    }
}