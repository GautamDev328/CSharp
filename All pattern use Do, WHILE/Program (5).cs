using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apatternusingwhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j;
            while (i <= 3)
            {
                j = 1;
                while (j <= 4)
                {
                    Console.Write("A");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadLine();
        }
    }
}
/*Output :
    AAAA
    AAAA
    AAAA
*/