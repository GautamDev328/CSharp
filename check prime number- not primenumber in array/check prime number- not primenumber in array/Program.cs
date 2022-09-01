using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_prime_number__not_primenumber_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 2, 3, 4, 5, 6, 7, 78, 54, 43, 6, 10 };
            //int num = int.Parse(Console.ReadLine());
            Console.Write("Enter a serial Number: ");
            int i = 0;
            while (i < n.Length)
            {
                Console.Write(n[i] + " ");
                i++;

            }
            Console.WriteLine(" ");
            Array.Reverse(n);
            Console.Write("Enter a reverse number : ");
            int j = 0;
            while (j < n.Length)
            {
                Console.Write(n[j] + " ");
                j++;
            }
            Console.WriteLine(" ");
            Console.Write("Enter a total Number : ");
            Console.Write(n.Length);

            int k= 2;
            int L = 1;
           int M = 1;
            int prime = 0;
            int notprime = 0;
            while (k <= 12)
            {
                while (L < n[M]/ 2)
                {
                    if (n[M] % L == 0)

                        notprime++;
                    else
                        prime++;
                    L++;
                }
                k++;

                    

                }
            Console.WriteLine(" ");
            Console.WriteLine("Not prime: "+ notprime);
            Console.Write("Prime :"+ prime);
            Console.ReadLine();

        }

           

        }
            

        }
    


