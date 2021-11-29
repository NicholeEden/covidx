
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCORE_DATAACCESS.ToDelete
{
    class TestRequest // 3 req 1 myself[PatientID] 2 dep[PID + DID]
    {
        /// <summary>
        /// The day when this request was made
        /// </summary>
        public DateTime RequestDate { get; set; }

        /// <summary>
        /// The person making the request
        /// </summary>
        public int PatientID { get; set; }

        /// <summary>
        /// The person who is being tested
        /// </summary>
        public int? DependantID { get; set; } // is this null ?


    }
}
