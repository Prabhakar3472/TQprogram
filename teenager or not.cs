using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class teenager_or_not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 13&& num<=19) 
            { 
                Console.WriteLine("is a teenager");
            }
            else
            {
                Console.WriteLine("not teenager");
            }
           
        }
    }
}
