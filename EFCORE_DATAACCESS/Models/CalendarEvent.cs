﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCORE_DATAACCESS.Models
{
    public class CalendarEvent : ICalendarEvent
    {


        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool AllDay { get; set; }


        public virtual TestRequest TestRequest { get; set; }
    }
}
