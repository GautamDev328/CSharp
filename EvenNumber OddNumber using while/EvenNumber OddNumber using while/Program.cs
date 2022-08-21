using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber_OddNumber_using_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ctrl = 0;
            int num;
            while (ctrl < 5)
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
             
                  
                    Console.WriteLine(" " + "Even Number");
            
                else
                    Console.WriteLine("Odd Number");
            }
            Console.ReadLine();
        }
    }
}
