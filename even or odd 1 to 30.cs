using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TQprogram
{
    internal class even_or_odd_1_to_30
    {
        static void Main(string[] args)
        {
            
            int i = 1;
            for (i=1; i<=30; i++) 
            {
               if(i% 2 == 0) 
                {
                    Console.Write( i );
                }
               else  
                {
                    Console.WriteLine( );
                    Console.Write(i+" ");
                }
            }
        }
    }
}
