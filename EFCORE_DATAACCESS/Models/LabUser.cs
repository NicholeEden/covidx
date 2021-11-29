using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    [Table(name: "LabUser")]
    public partial class LabUser
    {
        public LabUser()
        {
            Tests = new HashSet<Test>();
        }

        public int LabUserId { get; set; }
        [Required]
        public string Idnumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        //  public string EmailAddress { get; set; }
        //[Required]
        //public string Qualification { get; set; }

        [Required]
        [ForeignKey(nameof(CovidXUser))]
        public string UserID { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
