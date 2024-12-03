namespace Coding_Exercise2_Fixing_Simple_Bugs
{
    internal class Program
    {
        public void CalculateAverage()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int average = (num1 + num2 + num3) / 3;
            Console.WriteLine("The average is: " + average);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.CalculateAverage();
        }
    }
}
