﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimesionalArray_Rsum_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter The Base Array Size : ");
            //int Row = int.Parse(Console.ReadLine());
            //Console.Write("Enter The Child  Array Size :");
            //int Col = int.Parse(Console.ReadLine());

            //int[,] arr = new int[Row, Col];

            //int ptr;
            //int ctr;
            //ctr = 0;
            //while (ctr < Row)
            //{
            //    ptr = 0;
            //    while (ptr < Col)
            //    {
            //        Console.Write("Enter The Value {0} :- ", (ctr + 1));
            //        arr[ctr, ptr] = int.Parse(Console.ReadLine());
            //        ptr++;
            //    }
            //    ctr++;
            //    Console.WriteLine();
            //}

            //int ctr1 = 0;
            //int ptr1;
            //while (ctr1 < Row)
            //{

            //    ptr1 = 0;
            //    while (ptr1 < Col)
            //    {
            //        Console.Write(" " + arr[ctr1, ptr1]);
            //        ptr1++;
            //    }
            //    ctr1++;
            //    Console.WriteLine();
            //}

            Console.Write("Enter a first Number ");
            int Row = int.Parse(Console.ReadLine());
            Console.Write("Enrer a second Number :");
            int Col = int.Parse(Console.ReadLine());
            int[,] ar = new int[Row, Col];
            int i = 0;
            int j;
            while (i < Row)
            {
                j = 0;
                while (j < Col)
                {
                    Console.Write("Enter anumber");
                    ar[i,j] = int.Parse(Console.ReadLine());
                    j++;
                }
               
                i++;
                Console.WriteLine();
            }

            //Console.WriteLine();
            //for (int i = 0; i < Row; i++)
            //{
            //    int Rsum = 0;
            //    for (int j = 0; j < Col; j++)
            //    {
            //        Rsum = Rsum + arr[i, j];
            //    }
            //    Console.WriteLine("Sum Of Row " + (i + 1) + " Element :" + Rsum);
             
            //}
            Console.ReadLine();
           
        }
    }
}
