using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class area_of_circle_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius");
            int radius=Convert.ToInt32(Console.ReadLine());
            double area = 0;
            area=3.14*radius*radius;
            Console.WriteLine("area of circle is: " + area);
            area=3.14*radius;
            Console.WriteLine("area of circle is: " + area);
        }
    }
}
