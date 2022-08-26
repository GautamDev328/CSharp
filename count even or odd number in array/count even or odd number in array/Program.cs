using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_even_or_odd_number_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Array Number: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int even = 0;
            int odd = 0;
            int k = 0;
           
            int L = 1;
            while (L <= n)
            {
                Console.Write("Enter  number: ");
                a[k] = int.Parse(Console.ReadLine());
                if (a[k] % 2 == 0)

                    even++;

                else

                    odd++;
                L++;
            }
            Console.WriteLine("Even Number : " + even);
            Console.WriteLine("Odd number : " + odd);
            Console.ReadLine();
        }
    }
}
/*
 * Enter a Array Number:
5
Enter  number: 12
Enter  number: 11
Enter  number: 3
Enter  number: 24
Enter  number: 2
Even Number : 3
Odd number : 2


*/





