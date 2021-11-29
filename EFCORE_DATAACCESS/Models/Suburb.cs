using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    public partial class Suburb
    {
        public Suburb()
        {
            Dependents = new HashSet<Dependent>();
            Patients = new HashSet<Patient>();
            SuburbsPreffereds = new HashSet<SuburbsPreffered>();
            TestRequests = new HashSet<TestRequest>();
        }

        public int SuburbId { get; set; }
        [Required]
        public string SuburbName { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public virtual City City { get; set; }
        public virtual ICollection<Dependent> Dependents { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
       // public virtual ICollection<Nurse> Nurses { get; set; }
        public virtual ICollection<SuburbsPreffered> SuburbsPreffereds { get; set; }
        public virtual ICollection<TestRequest> TestRequests { get; set; }
    }
}
