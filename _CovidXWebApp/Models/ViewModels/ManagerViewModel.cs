using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _CovidXWebApp.Models.ViewModels
{
    public class ManagerViewModel
    {

        //show tests performed by a specific nurse within a specific date range
        public int nurseID { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string DateInput { get; set; }



       

    }
}
