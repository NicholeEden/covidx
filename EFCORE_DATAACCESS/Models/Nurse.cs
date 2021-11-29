using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EFCORE_DATAACCESS.Models.CovidEnums;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    public partial class Nurse
    {
        public Nurse()
        {
            SuburbsPreffereds = new HashSet<SuburbsPreffered>();
            TestRequests = new HashSet<TestRequest>();
        }

        [Key]
        public int NurseId { get; set; }

        [Required]
        public string Idnumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string MobileNumber { get; set; }

        //[Required]
        //public string AddressLine1 { get; set; }

        [Required]
        public int SuburbId { get; set; }

        [Required]
        public DateTime YearQualified { get; set; }
        [Required]
        public Rank Rank { get; set; }

        //[Required]
        //public string Qualification { get; set; }
       // public string EmailAddress { get; set; }
        [ForeignKey(nameof(CovidXUser))]
        public string UserID { get; set; }

        //[ForeignKey(nameof(SuburbId))]
        //public virtual Suburb Suburb { get; set; }
        public virtual ICollection<SuburbsPreffered> SuburbsPreffereds { get; set; }
        public virtual ICollection<NurseSchedule> NurseSchedules { get; set; }
        public virtual ICollection<TestRequest> TestRequests { get; set; }
    }
}
