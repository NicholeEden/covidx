using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.Utility
{
    /// <summary>
    /// Data for the sub text drop-down input element
    /// </summary>
    public class SubtextOption
    {
        
      
            /// <summary>
            /// The main display text
            /// </summary>
            public string DisplayText { get; set; }

            /// <summary>
            /// The gray display subtext
            /// </summary>
            public string DisplaySubtext { get; set; }

            /// <summary>
            /// The ID value
            /// </summary>
            public int Value { get; set; }
        
    }
}
