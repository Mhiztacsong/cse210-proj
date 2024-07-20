using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some addresses
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create some events
        Event lecture = new Lecture("Tech Talk", "A talk on the latest in tech", new DateTime(2024, 8, 20), "10:00 AM", address1, "Dr. Smith", 100);
        Event reception = new Reception("Networking Event", "An event to network with professionals", new DateTime(2024, 9, 15), "6:00 PM", address1, "rsvp@event.com");
        Event outdoorGathering = new OutdoorGathering("Community Picnic", "A picnic in the park", new DateTime(2024, 7, 30), "12:00 PM", address2, "Sunny with a chance of clouds");

        // Store the events in a list
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Display event details
        foreach (Event evt in events)
        {
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine("------------------------------");
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine("------------------------------");
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine("==============================");
        }
    }
}