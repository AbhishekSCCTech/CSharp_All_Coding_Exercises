namespace Coding_Exercise9_Calculating_Average_Temperature
{
    internal class Program
    {
        public void PrintAverage(double[] temperatures)

        {
            double average = CalculateAverage(temperatures);
            Console.WriteLine($"The average temperature is: {average}");
        }

        public double CalculateAverage(double[] temperatures)
        {
            // TODO
            double sum = 0;
            for (int i = 0; i < temperatures.Length; i++)
            {
                sum += temperatures[i];
            }

            return sum / temperatures.Length;
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            double[] temperatures = { 22.34,56.65,98.6};
            p1.PrintAverage(temperatures);
        }
    }
}
