using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class print_gretest_number
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 24;
            int c = 14;

            if(a > b) 
            {
                Console.WriteLine("A is greater");
            }
            else if(b > c)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greater");
            }
        }
    }
}
