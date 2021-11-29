using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    public partial class MedicalAidPlan
    {
        public MedicalAidPlan()
        {
            Dependents = new HashSet<Dependent>();
            Patients = new HashSet<Patient>();
        }

        public int MedicalAidPlanId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int MedicalAidSchemeId { get; set; }

        [ForeignKey(nameof(MedicalAidSchemeId))]
        public virtual MedicalAidScheme MedicalAidScheme { get; set; }
        public virtual ICollection<Dependent> Dependents { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
