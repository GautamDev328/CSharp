﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace column_sum_in_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] ar = { { 1, 2, 3 }, { 2, 4, 6 }, { 6, 7, 8 } };
            //int i = 0;
            //int j;
            //while (i < 3)
            //{
            //    j = 0;
            //    while (j < 3)
            //    {
            //        Console.Write(ar[i, j] + " ");
            //        Console.Write("Enter {0}", (j + 1));
            //        j++;
            //    }
            //    i++;
            //    Console.WriteLine();

            //}
            Console.WriteLine("Enter the base array size: ");
            int Row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the child Array size: ");
            int Col = int.Parse(Console.ReadLine());
            int[,] ar = new int[Row, Col];
            int i = 0;
            int j;
            while (i < Row)
            {
                j = 0;
                while (j < Col)
                {
                    Console.Write("Enter the{0}:- ", (j + 1));
                    ar[i, j] = int.Parse(Console.ReadLine());
                    j++;
                }
                i++;
                Console.WriteLine();
            }


            int ctr = 0;
                int ptr;
                while (ctr < Row)
                {
                    ptr = 0;
                    while (ptr < Col)
                    {
                        Console.Write(" " + ar[ctr, ptr]);
                        ptr++;
                    }
                    ctr++;
                    Console.WriteLine();
                }
                // Console.ReadLine();
                Console.WriteLine();
            int csum;
                // int k = 0;
                for (int k = 0; k < Col; k++)
                {
                     csum = 0;
                    //j = 0;
                    for (int l = 0; l <Row; l++)
                    {

                        Console.WriteLine("sum" + (l + 1) + "Element:" + csum);
                        csum = csum + ar[l,k];
                    }
                    Console.WriteLine();
                Console.ReadLine();
            }

               
            }
        }
    }



/* output:
 * Enter the base array size:
4
Enter the child Array size:
3
Enter the1:- 1
Enter the1:- 7
Enter the1:- 9

Enter the2:- 0
Enter the2:- 6
Enter the2:- 5

Enter the3:- 6
Enter the3:- 8
Enter the3:- 6

Enter the4:- 8
Enter the4:- 7
Enter the4:- 5

 1 7 9
 0 6 5
 6 8 6
 8 7 5

sum1Element:0
sum2Element:1
sum3Element:8

sum1Element:0
sum2Element:0
sum3Element:6

sum1Element:0
sum2Element:6
sum3Element:14

sum1Element:0
sum2Element:8
sum3Element:15*/















