using EFCORE_DATAACCESS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.Models.ViewModels
{
    public class TestViewModel : ITest
    {
        [Display(Name = "Barcode")]
        [Required(ErrorMessage = "Barcode is required")]
        public string BarCode { get; set; }
        [Display(Name = "Blood Pressure")]
        [Required(ErrorMessage = "Blood Pressure is required")]
        public string BloodPressure { get; set; }

        [Display(Name = "Oxygen Level")]
        [Required(ErrorMessage = "Oxygen Level is required")]
        public int OxygenLevel { get; set; }

        [Required(ErrorMessage = "Temperature Level is required")]

       
       // public double  { get; set; }


       

        public double Temperature
        {
            get { 
                return Double.Parse(Temp);
            }
            set {
                Temperature = value; 
            }
        }

   

        [RegularExpression(@"^[0-9]{0,2}\,?[0-9]{0,2}$", ErrorMessage = "Invalid Temperature. Can only contain numbers")]
        public string Temp { get; set; }
        public int TestRequestId { get; set; }

        public string ModalID { get; set; }
    }
}
