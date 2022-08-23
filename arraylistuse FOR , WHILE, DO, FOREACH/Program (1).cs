using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_program_using_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            ar[0] = 501;
            ar[1] = 502;
            ar[2] = 503;
            ar[3] = 504;
            ar[4] = 505;
            int i = 0;
            foreach( int j in ar)
            {
                Console.WriteLine(ar[i]);
                i++;
            }
            Console.ReadLine();

        }
    }
}
/* output:
501
502
503
504
505

*/
