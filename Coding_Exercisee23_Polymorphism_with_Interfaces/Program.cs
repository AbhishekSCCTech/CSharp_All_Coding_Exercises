namespace Coding_Exercisee23_Polymorphism_with_Interfaces
{
    internal class Program
    {
        public interface IPayment
        {
            void ProcessPayment();
        }

        public class CreditCardPayment : IPayment
        {
            public void ProcessPayment()
            {
                Console.WriteLine("Processing credit card payment");
            }
        }

        public class PayPalPayment : IPayment
        {
            public void ProcessPayment()
            {
                Console.WriteLine("Processing PayPal payment");
            }
        }
        static void Main(string[] args)
        {
            CreditCardPayment ccp = new CreditCardPayment();
            ccp.ProcessPayment();

            PayPalPayment ppp = new PayPalPayment();
            ppp.ProcessPayment();
        }
    }
}
