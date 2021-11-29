using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCORE_DATAACCESS.Models
{
    public partial class Test : ITest
    {
        public int TestId { get; set; }
        [Required]
        public int TestRequestId { get; set; }
        [Required]
        public string BarCode { get; set; }
        [Required]
        public double Temperature { get; set; }
        [Required]
        public string BloodPressure { get; set; }
        [Required]
        public int OxygenLevel { get; set; }
        [Required]
        public DateTime TestDate { get; set; }
        [Required]
        public DateTime TestTime { get; set; }

#nullable enable
        public string? TestResult { get; set; }
#nullable enable
        public DateTime? ResultDate { get; set; }
#nullable enable
        public int? LabUserId { get; set; }
#nullable disable
        [ForeignKey(nameof(LabUserId))]
        public virtual LabUser LabUser { get; set; }
        [ForeignKey(nameof(TestRequestId))]
        public virtual TestRequest TestRequest { get; set; }
    }
}
