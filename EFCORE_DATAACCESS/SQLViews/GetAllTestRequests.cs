using System;
using System.ComponentModel.DataAnnotations;
using static EFCORE_DATAACCESS.Models.CovidEnums;

namespace EFCORE_DATAACCESS.SQLViews
{
    public class GetAllTestRequests//one row
    {
        [Key]
        public int TestRequestId { get; set; }

        public int RequesterId { get; set; }

        public int TestSubjectID { get; set; }

        public DateTime RequestDate{ get; set; }
        public TestRequestStatus RequestStatus { get; set; }

        public string TestAddress1{ get; set; }

        public string TestAddress2 { get; set; }

        public string SuburbName{ get; set; }

        public string FullName { get; set; }

        public string NurseName { get; set; }
        public DateTime? DateAssigned { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

    }
}