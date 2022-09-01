using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_parameter
{
    class Program
    {
         public static void Distance( params int[] arr)
        {
            Console.WriteLine("check the array length:  "+ arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("array number: "+" "+ arr[i]);

            }
        }
        static void Main(string[] args)
        {
            Distance(1, 2, 3, 45, 54);
            Console.ReadLine();
        }
    }
}
