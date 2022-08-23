using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleprogram_using_while
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
                while (j <= i)
                {
                    Console.Write((char)(64+j));
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
A
AB
ABC
ABCD
ABCDE
*/