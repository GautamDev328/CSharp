using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j;
            char ch = 'A';
            while (i <= 5)
            {
                j = 1;
                while (j <= 5)
                {
                    Console.Write(ch+" ");
                    j++;
                    ch++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadLine();
        }
    }
}
