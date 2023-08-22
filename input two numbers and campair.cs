using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class input_two_numbers_and_campair
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter a first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int num2= Convert.ToInt32(Console.ReadLine());

            if(num1 != num2)
            {
                Console.WriteLine("not equal number");
            }
            else
            {
                Console.WriteLine("equal number");
            }
        }
    }
}
