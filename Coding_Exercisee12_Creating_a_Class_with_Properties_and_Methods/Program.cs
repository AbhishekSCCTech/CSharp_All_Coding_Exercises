namespace Coding_Exercisee12_Creating_a_Class_with_Properties_and_Methods
{
    internal class Program
    {

            public static void Main(string[] args)
            {
                Person p1 = new Person("John", 30);
                p1.Greet();
                // TODO
            }

        public class Person
        {
            private string _name;
            private int _age;

            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }
            public int Age
            {
                get
                {
                    return _age;
                }
                set
                {
                    if (value > 0)
                    {
                        _age = value;
                    }
                    else
                    {
                        throw new ArgumentException("Age must be greater than 0.");
                    }
                }
            }


            public Person(String name1, int age1)
            {
                Name = name1; // Initialized fields
                Age = age1;
            }

            public void Greet()
            {
                Console.WriteLine($"Hello, my name is {_name} and I am {_age} years old.");
            }
        }
         
    }
}
