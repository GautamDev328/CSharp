using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_count_even_and_odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int even = 0;
            int odd = 0;
            while (i < 5)
            {
                Console.WriteLine("Enter a number :");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                    even++;
                else
                    odd++;
                i++;
            }
            Console.WriteLine("Even Number : "+ even);
            Console.WriteLine("Odd Number: "+ odd);
            Console.ReadLine();

        }
    }
}
/* Output:
 * Enter a number :
11
Enter a number :
12
Enter a number :
10
Enter a number :
13
Enter a number :
16
Even Number : 3
Odd Number: 2

*/