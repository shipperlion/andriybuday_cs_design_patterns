using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class PrototypeDemo
    {
        public static CalendarEvent GetExistingEvent()
        {
            var party = new CalendarEvent();
            var friends = new Attendee[1];

            var hlib = new Attendee { FirstName = "Hlib", LastName = "Ostrikov" };
            friends[0] = hlib;

            party.Attendees = friends;
            party.StartDateAndTime = new DateTime(2023, 7, 15, 16, 0, 0);
            party.Priority =

                return party;
        }
    }
}
