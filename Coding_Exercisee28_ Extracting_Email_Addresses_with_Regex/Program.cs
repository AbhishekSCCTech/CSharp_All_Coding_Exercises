using System.Text.RegularExpressions;

namespace Coding_Exercisee28__Extracting_Email_Addresses_with_Regex
{
    internal class Program
    {
        public void ExtractPatterns(string input)
        {
            string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        static void Main(string[] args)
        {
            string input = "abcd@gamil.com";
            Program p1 = new Program();
            p1.ExtractPatterns(input);
        }
    }
}
