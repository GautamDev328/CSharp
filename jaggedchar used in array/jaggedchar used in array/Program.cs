using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpleprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Simpleprogram");
            char[] arr = new char[5];
            arr[0] = 'A';
            arr[1] = 'B';
            arr[2] = 'c';
            arr[3] = 'D';
            arr[4] = 'E';
            for (int i = 0; i <= 4; i++)
            {

                Console.WriteLine(arr.Length);
                Console.WriteLine(arr);
                Console.ReadLine();
            }

        }
    }
}
