using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_pattern_using_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j;
            char ch = 'A';
            while (i < 5)
            {
                j = 1;
                while (j <= i)
                {
                    Console.Write(ch + " ");
                    j++;

                }
                Console.WriteLine();
                i++;
            }
            Console.ReadLine();
        }
    }
}
/*output
A
A A
A A A
A A A A
*/
