using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class CalendarEvent: CalendarPrototype
    {
        public Attendee[] Attendees { get; set; }
        public Priority Priority { get; set; }
        public DateTime StartDateAndTime { get; set; }

        public object Clone()
        {
            var copy = (CalendarEvent)base.Clone();
            var copiedAttendees = (Attendee[])Attendees.Clone();
            copy.Attendees = copiedAttendees;
            copy.Priority = (Priority)Priority.Clone();
            return copy;
        }

    }
}
