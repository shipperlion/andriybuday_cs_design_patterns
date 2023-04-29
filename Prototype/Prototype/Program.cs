using System;

namespace Prototype
{
    class Program
    {
        static void Main()
        {
            var party = GetExistingEvent();
            var nextEvent = (CalendarEvent)party.Clone();
            nextEvent.StartDateAndTime = new DateTime(2023, 7, 30, 19, 0, 0);

            nextEvent.Attendees[0].EmailAddress = "andriybuday@liamg.com";
            nextEvent.Priority.SetPriorityValue(0);
            if (party.Attendees != nextEvent.Attendees)
            {
                Console.WriteLine("GOOD: Each event has own list of attendees.");
            }
            if (party.Attendees[0].EmailAddress ==
            nextEvent.Attendees[0].EmailAddress)
            {
                Console.WriteLine(
                "GOOD: Update to my e-mail address will be reflected in all events.");
            }
            if (party.Priority.IsHigh() != nextEvent.Priority.IsHigh())
            {
                Console.WriteLine(
                "GOOD: Each event should have own priority object, fully-copied.");
            }
        }
        public static CalendarEvent GetExistingEvent()
        {
            var party = new CalendarEvent();
            var friends = new Attendee[1];

            var hlib = new Attendee { FirstName = "Hlib", LastName = "Ostrikov" };
            friends[0] = hlib;
            var priority = new Priority();
            party.Priority = priority;

            party.Attendees = friends;
            party.StartDateAndTime = new DateTime(2023, 7, 15, 16, 0, 0);
            party.Priority.SetPriorityValue(5);

            return party;
        }
    }
    
}
