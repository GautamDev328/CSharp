using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimesionalArray_2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 101, 10, 03, 04 }, { 201, 02, 03, 04 }, { 301, 02, 03, 04 } };
            int i = 1;
            int j;
            while (i<=3)
            {
                 j = 1;
                while(j<=4)
                { 

                    Console.WriteLine(arr[i,j]+" ");
                    j++;
                }
                Console.WriteLine();
                i++;

                Console.ReadLine();

            }
           

        }
    }
}
