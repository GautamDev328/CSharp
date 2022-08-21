using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorail_using_whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ctrl = 1, fact = 1;
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            while (ctrl<=num)
            {
                fact = fact * ctrl;
                Console.WriteLine("factor is :"+ num + " is :"+fact);
                ctrl++;
            }
            Console.ReadLine();
        }
    }
}
