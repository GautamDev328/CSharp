using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int i = 1;
            int j = 1;
            //   int j = int.Parse(Console.ReadLine());
            /*  while (i<= 100)
              {
                  Console.WriteLine(i);
                  i++;

              }
              Console.ReadLine();*/
            /*  while (i <= 20)
              {
                  Console.WriteLine(i);
                  i = i + 2;

              }
              Console.ReadLine();

          }*/
            while (i <= 10)
            {
                i++;
            
                while (j <= i)
                {
                 
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

