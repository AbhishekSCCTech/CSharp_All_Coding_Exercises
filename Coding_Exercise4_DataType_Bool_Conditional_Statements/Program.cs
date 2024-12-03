namespace Coding_Exercise4_DataType_Bool_Conditional_Statements
{
    internal class Program
    {
        public void CheckLogin()
        {
            bool isLoggedIn = true;

            // Assign a value to isLoggedIn based on user input or condition


            if (isLoggedIn)
            {
                Console.WriteLine("Welcome back!");
            }
            else
            {
                Console.WriteLine("Please log in.");
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.CheckLogin();
        }
    }
}
