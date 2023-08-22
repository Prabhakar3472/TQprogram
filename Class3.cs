using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{                                                   //wc to check even no is divisible by three or not
    internal class Class3
    {

       static void Main(string[] args)
       {

            Console.WriteLine("enter no");
            int num = Convert.ToInt32(Console.ReadLine());

            string no = (num % 3 == 0) ? "Even num is divisible" : "Even num is not divisible";
            Console.WriteLine(no);



        }
           
    }
}
