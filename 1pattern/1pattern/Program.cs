using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1pattern
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
                while (j <= 5){
                    Console.Write("1");
                    j = j + 1;

                }
                Console.WriteLine();
                i = i + 1;
            }
            Console.ReadLine();
        }
    }
}
