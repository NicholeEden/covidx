using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    public partial class SuburbsPreffered
    {
        public int SuburbId { get; set; }
        public int NurseId { get; set; }

        [ForeignKey(nameof(NurseId))]
        public virtual Nurse Nurse { get; set; }
        [ForeignKey(nameof(SuburbId))]
        public virtual Suburb Suburb { get; set; }
    }
}
