using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    public partial class MedicalAidScheme
    {
        public MedicalAidScheme()
        {
            MedicalAidPlans = new HashSet<MedicalAidPlan>();
        }

        public int MedicalAidSchemeId { get; set; }
        [Required]
        public string Description { get; set; }

        public virtual ICollection<MedicalAidPlan> MedicalAidPlans { get; set; }
    }
}
