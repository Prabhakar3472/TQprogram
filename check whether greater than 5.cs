using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class check_whether_greater_than_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            
            if(num <5) 
            {
                Console.WriteLine(num + "is less than 5");
            }
            else if(num >5)
            {
                Console.WriteLine(num + " is greater than 5");
            }
            else 
            {
               Console.WriteLine(num+"is equal to 5 ");
            }
        }
    }
}
