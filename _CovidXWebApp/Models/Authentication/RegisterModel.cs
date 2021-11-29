using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.Models.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Email is required."),
           DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is required"),
            MinLength(8),
            DataType(DataType.Password)]
        public string Password { get; set; }

        [Required,
            Compare(nameof(Password)),
            DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        ////Patient fields
        //[Required(ErrorMessage ="First Name is required")]
        //public string FirstName { get; set; }

        //[Required(ErrorMessage = "Last Name is required")]
        //public string LastName { get; set; }

        //[Required(ErrorMessage ="ID is required"), MaxLength(13, ErrorMessage ="Please enter a valid ID")]
        //public string Idnumber { get; set; }

        //[Required]
        //public DateTime DateOfBirth { get; set; }

        //[Required(ErrorMessage ="Mobile Number is required")]
        //public string MobileNumber { get; set; }

        //[Required(ErrorMessage = " AddressLine1 is required")]
        //public string AddressLine1 { get; set; }


        //public string AddressLine2 { get; set; }

       
        

        //public string SuburbName { get; set; }

        //[Required(ErrorMessage = "Suburb is required")]
        //public int SuburbID { get; set; }
    }
}
