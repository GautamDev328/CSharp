using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_program_in_sum_count_all_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while (i <= 5)
            {
                Console.WriteLine("Enter a Number: ");
                int j = int.Parse(Console.ReadLine());
                //  int k = 1;
                sum = sum + j;
                i++;

            }
            Console.WriteLine("Sum Number: " + sum);
            Console.ReadLine();
        }
    }
}
/* OUTPUT:
  Enter a Number:
12
Enter a Number:
1
Enter a Number:
12
Enter a Number:
1
Enter a Number:
12
Sum Number: 38
*/

    