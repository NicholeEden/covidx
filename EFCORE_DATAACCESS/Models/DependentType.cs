using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    [Table(name: "DependentType")]
    public partial class DependentType
    {
        public DependentType()
        {
            Dependents = new HashSet<Dependent>();
        }

        public int DependentTypeId { get; set; }
        [Required]
        public string Description { get; set; }

        public virtual ICollection<Dependent> Dependents { get; set; }
    }
}
