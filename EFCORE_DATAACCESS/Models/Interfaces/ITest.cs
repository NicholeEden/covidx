using System;

namespace EFCORE_DATAACCESS.Models
{
    public interface ITest
    {
        string BarCode { get; set; }
        string BloodPressure { get; set; }
        int OxygenLevel { get; set; }
        double Temperature { get; set; }
 
        int TestRequestId { get; set; }
      
    }
}