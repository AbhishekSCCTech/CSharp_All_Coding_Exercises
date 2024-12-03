namespace Coding_Exercisee14__Any_Method_List
{
    internal class Program
    {
        public void CheckAny()
        {
            // The list has been declared for you, use it in your solution.
            List<int> myNumbers = new List<int> { 1, 6, 3 };

            // TODO: Check if any number is greater than 5 using the Any method
            bool result = myNumbers.Any(x => x > 5);
            // and print the result ("True" or "False") to the console.
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Program program = new Program();    
            program.CheckAny();
        }
    }
}
