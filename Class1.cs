using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hii");
            int a = 2;
            int b = 3;

            int x = ++a + ++b;
            Console.WriteLine(x + " " + a + " " + b);//7,3,4

            x = ++a - b--;
            Console.WriteLine(x + " " + a + " " + b);//-1,4,3

            x = ++a - b++;
            Console.WriteLine(x + " " + a + " " + b);//2,5,4

            x = --a - --b - a;
            Console.WriteLine(x + " " + a + " "+b);//-3,4,3

            x = b++ - a-- + b;
            Console.WriteLine(x + " " + a + " " + b);//3,3,4

            x = ++a + ++b - b;
            Console.WriteLine(x + " " + a + " " + b);//4,4,5

        }




    }
}
