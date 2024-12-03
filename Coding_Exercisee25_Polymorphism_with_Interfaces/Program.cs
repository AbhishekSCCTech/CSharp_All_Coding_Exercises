namespace Coding_Exercisee25_Polymorphism_with_Interfaces
{
    internal class Program
    {
        public interface IShape
        {
            double GetArea();
        }

        public class Circle : IShape
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }
            public double GetArea()
            {
                return Math.PI * radius * radius;
            }
        }

        public class Rectangle : IShape
        {
            private double width;
            private double height;

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public double GetArea()
            {
                return width * height;
            }
        }
        static void Main(string[] args)
        {

            IShape[] shapes = new IShape[]
            {
                new Circle(5),
                new Rectangle(4,6)
            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Area: {shape.GetArea()}");
            } 
      }
    }
}
