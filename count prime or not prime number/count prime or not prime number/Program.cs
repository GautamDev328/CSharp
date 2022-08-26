using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_prime_or_not_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Array Number: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int prime = 0;
            int notprime = 0;
            int i = 1;
            int k = 0;Boolean chek = true;int kk = 0;int fix = 0;
            while (i <= n)
            {
                Console.WriteLine("Enter a number: ");
                a[k] = int.Parse(Console.ReadLine());
               

                if (a[k] == 1 || a[k] == 1)
                {
                    fix++;
                    i++;
                    continue;
                }
                else
                {
                    int count = 1; notprime = 0;
                    while (count <= a[k])
                    {
                        if (a[k] % count == 0)
                        {
                            notprime++;
                        }
                        count++;
                    }
                    if (notprime == 2)
                    {
                        prime++;
                    }
                }
                i++;
                

            }

            Console.WriteLine("NotPrime " + (n - prime - fix));
            Console.WriteLine("Prime :" + prime);
            Console.ReadLine();


        }
    }
}
