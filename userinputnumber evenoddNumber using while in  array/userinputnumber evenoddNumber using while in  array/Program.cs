using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinputnumber_evenoddNumber_using_while_in__array
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int[] arr1 = new int[10];
                int[] arr2 = new int[10];
                int[] arr3 = new int[10];
                int i, j = 0, k = 0, n;


                //Console.Write("Separate odd and even integers in separate arrays:\n");
                

                Console.Write("Input the number of elements to be stored in the array :");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (i = 0; i < n; i++)
                {
                    if (arr1[i] % 2 == 0)
                    {
                        arr2[j] = arr1[i];
                        j++;

                    }
                    else
                    {
                        arr3[k] = arr1[i];
                        k++;
                    }
                }

                Console.Write("\nThe Even elements are : \n");
                for (i = 0; i < j; i++)
                {
                    Console.Write("{0} ", arr2[i]);
                }

                Console.Write("\nThe Odd elements are :\n");
                for (i = 0; i < k; i++)
                {
                    Console.Write("{0} ", arr3[i]);
                }
                Console.Write("\n\n");
            Console.ReadLine();

        }
        
        }
    }
/*
 output:
Input the number of elements to be stored in the array :5
Input 5 elements in the array :
element - 0 : 23
element - 1 : 23
element - 2 : 12
element - 3 : 335
element - 4 : 7

The Even elements are :
12
The Odd elements are :
23 23 335 7
*/

