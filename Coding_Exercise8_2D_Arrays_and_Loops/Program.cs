namespace Coding_Exercise8_2D_Arrays_and_Loops
{
    internal class Program
    {
        public void PrintRowSums()
        {
            int[,] array = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += array[i, j];
                }
                Console.WriteLine(sum);
            }
        }
            //
       static void Main(string[] args)
        {
            Program p1 = new Program(); 
            p1.PrintRowSums();
        }
    }
}
