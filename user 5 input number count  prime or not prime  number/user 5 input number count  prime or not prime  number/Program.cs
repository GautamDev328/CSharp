using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_5_input_number_count__prime_or_not_prime__number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int prime = 0;
            int notprime = 0;
            //int i = 0;


            while (n <= 5)
            {
                Console.WriteLine("Enter a number: ");
                int i = int.Parse(Console.ReadLine());

                int j = 1;
                while (j <= i / 2)
                {
                    if (i % 2 == 0)
                    {
                        notprime++;
                        break;
                    }
                    else
                    {
                        prime++;
                        break;
                    }
                    j++;
                }
                n++;
            }
            Console.WriteLine("Not prime: " + notprime);
            Console.WriteLine("Prime: " + prime);
            Console.ReadLine();
        }

    }
}
/* output: Enter a number:
12
Enter a number:
11
Enter a number:
17
Enter a number:
7
Enter a number:
45
Not prime: 1
Prime: 4

*/

     