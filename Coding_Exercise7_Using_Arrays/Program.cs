namespace Coding_Exercise7_Using_Arrays
{
    internal class Program
    {
        public void PrintNumbers()
        {
            // Initialize array and print each number using a foreach loop
            int[] array = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();        
            program.PrintNumbers();
        }
    }
}
