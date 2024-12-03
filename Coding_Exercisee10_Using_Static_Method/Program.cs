namespace Coding_Exercise10_Using_Static_Method
{
    internal class Program
    {
        public static int DoubleValue(int number)
        {
            // TODO: Implement the method to double the value
            int result = number * 2;
            return result;
        }

        public static void Main(string[] args)
        {
            int result = DoubleValue(10);
            Console.WriteLine(result);
        }
    }
}
