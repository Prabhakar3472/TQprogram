using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class area_of_circle
    {
        static void Main(string[] args)
        {
            int radius = 4;
            float pi = 3.14f, area;
            area= pi * radius*radius;

            Console.WriteLine(area);
        }
    }
}
