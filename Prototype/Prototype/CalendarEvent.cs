using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class CalendarEvent : CalendarPrototype
    {
        public Attendee[] Attendees { get; set; }
        public Priority Priority { get; set; }
        public DateTime StartDateAndTime { get; set; }
    }
}
