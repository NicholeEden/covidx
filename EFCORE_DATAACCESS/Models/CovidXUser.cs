using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    public partial class CovidXUser : IdentityUser
    {
        //public string UserName { get; set; }
        //public string PasswordHash { get; set; }
        //public string Avatar { get; set; }
        //public bool Active { get; set; }
        //public string UserType { get; set; }

        /// <summary>
        /// The path of the avatar image
        /// </summary>

       #nullable enable
        public string? Avatar { get; set; }
     


        /// <summary>
        /// Is the user active?
        /// </summary>

        public bool IsActive { get; set; }

        /// <summary>
        /// Defines if the user is a Nurse or a Patient
        /// </summary>

       [Required]
       public string? UserType { get; set; }

        /// <summary>
        /// Link to the Nurse table
        /// </summary>

      
      
    }
}
