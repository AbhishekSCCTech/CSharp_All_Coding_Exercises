namespace Coding_Exercise5__Switch_Statement
{
    internal class Program
    {
        public void PrintDay()
        {
            int day = 3;

            // TODO: Rewrite this if-else structure using a switch statement.
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;

            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();    
            program.PrintDay();
        }
    }
}
