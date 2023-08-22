using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class greater_age_hi_hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int b=Convert.ToInt32(Console.ReadLine());
            if (a > b) 
            {
                Console.WriteLine("hello");
            }
             else  if (b > a) 
            {
                Console.WriteLine("hi");
            }
            else 
            {
                Console.WriteLine("hello hi");
            }

        }
    }
}
