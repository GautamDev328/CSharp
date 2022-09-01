using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeat_array_program_using_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 401;
            arr[1] = 402;
            arr[2] = 403;
            arr[3] = 404;
            arr[4] = 405;
            int i = 0;
            while (i <= 4)
            {
                Console.WriteLine(arr[i]);
                i++;
            }
            Console.ReadLine();
        }

    }
}
