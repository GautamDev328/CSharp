using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_program_using_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j;
            while (i <= 6)
            {
                j = 1;
                while (j <= i)
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
1
22
333
4444
55555
666666
*/