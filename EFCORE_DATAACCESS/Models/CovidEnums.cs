using System;
using System.Collections.Generic;
using System.Text;

namespace EFCORE_DATAACCESS.Models
{
   public  class CovidEnums
    {
        /// <summary>
        /// Defines the options available to the database fields representing gender
        /// </summary>
        public enum Gender
        {
            Female,
            Male,
            Intersex,
            Transgender
        }

        public enum TestRequestStatus
        {
            New,
            Cancelled,
            Assigned,
            Scheduled,
            Performed,
            AtLab,
            Closed
        }

        public enum Rank
        {
            General,
            Enrolled,
            Specialized,
            Midwife

        }

        

        
    }
}
