using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class prime_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= num / 2; i++) //99
            {
                if (num % i == 0)
                {
                    num = 0;
                    
                }
            }
                
                
                if (num == 0)
                {
                    Console.WriteLine("not prime");

                }
                else 
                {
                  Console.Write("prime");
                }

            
        }
    }
	
	
}

