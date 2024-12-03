namespace Coding_Exercisee21_Advanced_Method_Overriding
{
    internal class Program
    {
        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal makes a sound");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat meows");
            }
        }
        static void Main(string[] args)
        {
            Animal an = new Animal();
            an.MakeSound();

            Dog dg = new Dog();
            dg.MakeSound();

            Cat ct = new Cat();
            ct.MakeSound();
   
        }
    }
}
