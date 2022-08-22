using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, fact = 1;
            Console.WriteLine("Enter a Number:");
            int num = int.Parse(Console.ReadLine());
            do
            {
                fact = fact * i;
                Console.WriteLine("fact of: " + num + "is: " + fact);
                i++;
            } while (i <=num);
            Console.ReadLine();
        }
    }
}
