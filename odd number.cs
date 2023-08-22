using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class odd_number
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=100; i++) 
            {
              if(i % 2!= 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
