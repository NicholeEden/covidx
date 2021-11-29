using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EFCORE_DATAACCESS.Models.CovidEnums;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    public partial class TestRequest
    {
        public TestRequest()
        {
            
        }

        public int TestRequestId { get; set; }
        [Required]
        public int PatientId { get; set; }
        #nullable enable
        public int? DependentId { get; set; }

        //Date on which the test request was made
        [Required]
        public DateTime RequestDate { get; set; }
        [Required]
        public TestRequestStatus RequestStatus { get; set; }
        [Required]
        public string TestAddress1 { get; set; }
        #nullable enable
        public string? TestAddress2 { get; set; }
        [Required]
        public int SuburbId { get; set; }
        #nullable enable
        public int? NurseId { get; set; }
        public DateTime? DateAssigned { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        #nullable enable
        public int? CalenderEventID { get; set; }

        [ForeignKey(nameof(CalenderEventID))]
        public CalendarEvent? CalenderEvent { get; set; }

       


        [ForeignKey(nameof(DependentId))]
        public virtual Dependent? Dependent { get; set; }

        [ForeignKey(nameof(NurseId))]
        public virtual Nurse? Nurse { get; set; }

        [ForeignKey(nameof(PatientId))]
        public virtual Patient Patient { get; set; }

        [ForeignKey(nameof(SuburbId))]
        public virtual Suburb Suburb { get; set; }

        public virtual Test Test { get; set; }

        public virtual ICollection<NurseSchedule> NurseSchedules { get; set; }
    }
   
}
