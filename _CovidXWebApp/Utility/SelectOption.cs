using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.Models
{
    public class SelectOption
    {
        /// <summary>
        /// Defines the id value to be used
        /// </summary>
      public  string Key { get; set; }

        /// <summary>
        /// Defines the diplay value to be used
        /// </summary>
       public  string Value { get; set; }

        /// <summary>
        /// Defines the display value for subtext
        /// </summary>
       public string Subtext { get; set; }
    }
}
