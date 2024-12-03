namespace Coding_Exercisee11_Read_Only_Properties
{
    internal class Program
    {
        public class MyClass
        {
            // TODO: Declare a private readonly field to store the value
            private readonly string field;
            // TODO: Create a public read-only property to expose the field's value
            public string getField
            {
                get
                {
                    return field;
                }
            }

            public MyClass(string value)
            {
                field = value;
                // TODO: Initialize the readonly field with the value parameter
            }
        }

        public class Exercise
        {
            public void PrintReadOnlyProperty()
            {
                MyClass myclass = new MyClass("Read-Only Property Value");
                Console.WriteLine(myclass.getField);
                // TODO: Create an instance of MyClass with the value "Read-Only Property Value"
                // TODO: Print the value of the read-only property to the console
            }
        }
        static void Main(string[] args)
        {
            Exercise e1 = new Exercise();
            e1.PrintReadOnlyProperty();
        }
    }
}
