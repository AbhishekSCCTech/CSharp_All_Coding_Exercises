using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise1_Simple_Variables_Introduction
{
    internal class Class1
    {
        public void PrintNumber()
        {
            int printvalu = 10;
            Console.WriteLine(printvalu);
        }

        public static void Main() { 
            Class1 c1 = new Class1();
            c1.PrintNumber();
        }
    }
}
