namespace Coding_Exercisee19_Working_with_Inheritance_Base_Keyword
{
    internal class Program
    {
        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal sound");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                base.MakeSound();
                Console.WriteLine("Dog barks");
            }
        }

        public class Exercise
        {
            public void PrintSounds()
            {
                Dog d1 = new Dog();
                d1.MakeSound()
            }
        }
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintSounds();
        }
    }
}
