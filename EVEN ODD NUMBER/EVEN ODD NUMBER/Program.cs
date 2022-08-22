using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEN_ODD_NUMBER
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num;
            int even = 0;
            int odd = 0;
            do
            {
                Console.WriteLine("Enter a number:");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                    even++;
                else
                    odd++;
                i++;
            } while (i < 5);
            Console.WriteLine("Total Even Number: "+ even);
            Console.WriteLine("Total Odd Number: "+ odd);
            Console.ReadLine();
        }
    }
}
