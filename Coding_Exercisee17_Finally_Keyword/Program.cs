namespace Coding_Exercisee17_Finally_Keyword
{
    internal class Program
    {
        public void PrintWithFinally()
        {
            try
            {
                Console.WriteLine("Trying...");
            }
            finally
            {
                Console.WriteLine("Finally executed.");
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();    
            program.PrintWithFinally();
        }
    }
}
