using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    [Table(name:"City")]
    public partial class City
    {
        public City()
        {
            Suburbs = new HashSet<Suburb>();
        }

        public int CityId { get; set; }
        [Required]
        public string CityName { get; set; }

        public virtual ICollection<Suburb> Suburbs { get; set; }
    }
}
