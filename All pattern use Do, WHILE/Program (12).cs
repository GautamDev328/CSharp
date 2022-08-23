using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_usingWhile
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
                while (j <= 4)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadLine();
        }
    }
}

/* output :
 ****
 ****
 ****
 ****
 ****   */