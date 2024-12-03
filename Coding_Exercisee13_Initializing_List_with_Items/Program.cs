namespace Coding_Exercisee13_Initializing_List_with_Items
{
    internal class Program
    {
        public void PrintNumbers()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            // TODO
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program(); 
            p1.PrintNumbers();
        }
    }
}
