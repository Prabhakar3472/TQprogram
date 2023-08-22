using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class check_kaprekar_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            num = 0;
            int count = 0;
            int squere = num * num;

            int copy = num;
            while (num > 0) 
            {
                count++;
                num = num / 10;
            }
            int power = 1;
            for (int i = 1; i <= count; i++) 
            {
                power = power * 10;
            
            }
            int end = squere % power;
            int start =squere / power;
            Console.WriteLine(end + start);



        }
    }
}
