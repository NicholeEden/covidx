using EFCORE_DATAACCESS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static EFCORE_DATAACCESS.Models.CovidEnums;

namespace _CovidXWebApp.Models
{
    public class NurseSuburbsModel
    {

        public int[] SelectedSuburbsIds { get; set; }

        public int NurseId { get; set; }

        public int SuburbId { get; set; }




    }
}
