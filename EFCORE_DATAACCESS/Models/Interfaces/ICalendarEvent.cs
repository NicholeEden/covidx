using System;

namespace EFCORE_DATAACCESS.Models
{
    public interface ICalendarEvent
    {
        bool AllDay { get; set; }
        string Description { get; set; }
        DateTime End { get; set; }
        int ID { get; set; }
        DateTime Start { get; set; }
        string Title { get; set; }
    }
}