using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_even_and_odd_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Enter a number :");
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
            Console.WriteLine(" count Even number :"+ even );
            Console.WriteLine(" count Odd number: "+ odd);
            Console.ReadLine();
        }
    }
}
