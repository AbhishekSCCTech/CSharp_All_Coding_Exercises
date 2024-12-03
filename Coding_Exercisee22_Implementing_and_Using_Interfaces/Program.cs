namespace Coding_Exercisee22_Implementing_and_Using_Interfaces
{
    internal class Program
    {
        public interface IVehicle
        {
            void Drive();
            // TODO: Declare a method Drive
        }

        public class Car : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("Car is driving");
            }
            // TODO: Implement the Drive method
        }

        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Drive();
        }
    }
}
