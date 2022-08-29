using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zprogram_in_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[4];
            arr[2] = new int[2];
            arr[0][0] = 1;
            arr[0][1] = 3;
            arr[0][2] = 5;


            arr[1][0] = 2;
            arr[1][1] = 4;
            arr[1][2] = 6;
            arr[1][3] = 8;

            arr[2][0] = 1;
            arr[2][1] = 9;
            //   int[] ar = {{ 1, 2, 3 },{ 2,4,5,6,7},{ 1,3,4,5,6,7,8} };
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");

                }
                Console.WriteLine();
               

            }
            Console.ReadLine();

        }
    }
}
