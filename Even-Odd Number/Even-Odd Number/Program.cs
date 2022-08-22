using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num;
            do
            {
                Console.WriteLine("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                    Console.WriteLine("Even Number ");
                else
                    Console.WriteLine("Odd Number ");
                i++;
            } while (i < 5);
            Console.ReadLine();
        }
    }
}
