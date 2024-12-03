namespace Coding_Exercisee16_Advanced_Dictionary_Operations
{
    internal class Program
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public int Grade { get; set; }

            // Constructor that initializes the Student object
            public Student(int id, string name, int grade)
            {
                Id = id;
                Name = name;
                Grade = grade;
            }
        }

        public void PrintStudents()
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            students.Add("John", new Student(1, "John", 85));
            students.Add("Alice", new Student(2, "Alice", 90));
            students.Add("Bob", new Student(3, "Bob", 78));

            foreach (var student in students.Values)
            {
                Console.WriteLine($"Name: {student.Name}, Id: {student.Id}, Grade: {student.Grade}");
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.PrintStudents();
        }
    }
}
