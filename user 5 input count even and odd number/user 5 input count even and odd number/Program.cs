﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_5_input_count_even_and_odd_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int even = 0;
            int odd = 0;
            while (n <= 5)
            {
                Console.WriteLine("Enter a number: ");
                int i = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    even++;
                else
                    odd++;
                n++;
            }
            Console.WriteLine(" count Even number :" + even);
            Console.WriteLine(" count Odd number: " + odd);
            Console.ReadLine();
        }
    }
}
/* Output:
Enter a number:
12
Enter a number:
11
Enter a number:
15
Enter a number:
24
Enter a number:
19
 count Even number :2
 count Odd number: 3

 */
