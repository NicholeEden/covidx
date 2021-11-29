
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCORE_DATAACCESS.Models
{
   public class NurseSchedule
    {
        public int TestRequestId { get; set; }
        public int NurseId { get; set; }

        [ForeignKey(nameof(NurseId))]
        public virtual Nurse Nurse { get; set; }
        [ForeignKey(nameof(TestRequestId))]
        public virtual TestRequest TestRequest { get; set; }
    }
}
