namespace Coding_Execisee26_Using_Structs_with_DateTime_math
{
    internal class Program
    {
        public struct Event
        {
            public DateTime StartDate;
            public DateTime EndDate;


            public Event(DateTime startDate, DateTime endDate)
            {
                if (startDate >= endDate)
                    throw new ArgumentException("StartDate must be before EndDate");

                StartDate = startDate;
                EndDate = endDate;
            }

            public double GetDuration()
            {
                return (EndDate - StartDate).TotalDays;
            }

            public bool IsOverlapping(Event otherEvent)
            {
                return StartDate < otherEvent.EndDate && EndDate > otherEvent.StartDate;

            }
        }
        static void Main(string[] args)
        {
            Event event1 = new Event(new DateTime(2024, 7, 1), new DateTime(2024, 7, 10));
            Event event2 = new Event(new DateTime(2024, 7, 5), new DateTime(2024, 7, 15));

            Console.WriteLine($"Event 1 Duration: {event1.GetDuration()} days");
            Console.WriteLine($"Event 2 Duration: {event2.GetDuration()} days");

            Console.WriteLine($"Events Overlap: {event1.IsOverlapping(event2)}");
        }
    }
}
