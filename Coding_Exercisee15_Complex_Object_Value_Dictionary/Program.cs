namespace Coding_Exercisee15_Complex_Object_Value_Dictionary
{
    internal class Program
    {
        public void PrintDictionaryValues()
        {
            Dictionary<string, List<int>> myDict = new Dictionary<string, List<int>>
            {
                {"numbers", new List<int>{1,2,3}}
            };

            foreach (int number in myDict["numbers"])
            {
                Console.Write(number + " ");
            }
            // TODO
        }
        static void Main(string[] args)
        {
            Program program = new Program();        
            program.PrintDictionaryValues();
        }
    }
}
