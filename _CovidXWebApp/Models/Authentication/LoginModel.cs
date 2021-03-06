using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.Models.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is required."),
               DataType(DataType.EmailAddress)]

        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required."),
            DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// Allow the user to decide if they will be remembered
        /// </summary>
        public bool RememberMe { get; set; }

     
    }
}
