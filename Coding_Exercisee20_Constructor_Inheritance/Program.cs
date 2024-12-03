namespace Coding_Exercisee20_Constructor_Inheritance
{
    internal class Program
    {
        public class Person
        {
            public Person(string name)
            {
                Console.WriteLine($"Person constructor: {name}");
            }
            // TODO: Declare a constructor that takes a name and prints a message
        }

        public class Employee : Person
        {
            public Employee(string name, int ID) : base(name)
            {
                Console.WriteLine($"Employee constructor: {name}, ID: {ID}");
            }
            // TODO: Declare a constructor that takes a name and an ID, and calls the base class constructor
        }

     
        static void Main(string[] args)
        {
            Employee em = new Employee("John Doe", 123);
        }
    }
}
