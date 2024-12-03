namespace Coding_Exercise6_Calculator
{
    internal class Program
    {
        public void SimpleCalculator()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose an operation: +, -, *, /");
            string operation = Console.ReadLine();
            // char operation:

            double result;

            if (operation == "+")
            {
                result = num1 + num2;
                Console.WriteLine($"Result: {result}");
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                Console.WriteLine($"Result: {result}");
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                Console.WriteLine($"Result: {result}");
            }

            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();    
            program.SimpleCalculator();
        }
    }
}
