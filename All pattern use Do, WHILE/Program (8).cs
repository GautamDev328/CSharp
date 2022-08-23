using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternprogreamusign_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j;
            while (i <= 5)
            {
                j = 1;
                while (j <= 5)
                {
                    Console.Write(i);
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadLine();
        }
    }
}
/* output: 
11111
22222
33333
44444
55555
*/
