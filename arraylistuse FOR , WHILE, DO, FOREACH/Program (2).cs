using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_program_using_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            ar[0] = 101;
            ar[1] = 102;
            ar[2] = 103;
            ar[3] = 104;
            ar[4] = 105;
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(ar[i]);
                i++;

            }
            Console.ReadLine();
        }
    }
}
/*
 101
102
103
104
105
*/