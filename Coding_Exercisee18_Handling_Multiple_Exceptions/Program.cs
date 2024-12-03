namespace Coding_Exercisee18_Handling_Multiple_Exceptions
{
    internal class Program
    {
        public void HandleMultipleExceptions(string numberString, int index)
        {

            int[] numbers = { 1, 2, 3 };
            try
            {
                int number = int.Parse(numberString);
                Console.WriteLine(numbers[index]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.HandleMultipleExceptions("abc",2);
        }
    }
}
