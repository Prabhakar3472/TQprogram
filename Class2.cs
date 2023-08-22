using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class Class2
    {
        static void Main(string[] args)
        {

            int a = 7, b = 9;
            int result = (a > b) ? a : b;
            Console.WriteLine(result);
            string result2 = (a > b) ? "a is greater number" : "a is smaller number";
        }            
    }
}
