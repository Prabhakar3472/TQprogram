using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class check_whether_even_or_odd_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            if(num % 2==0 ) 
            {
             Console.WriteLine("Entered number is even");
            }
            else 
            {
              Console.WriteLine("Entered number is odd");
            }
        }
    }
}
