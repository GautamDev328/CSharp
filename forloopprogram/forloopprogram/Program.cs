using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloopprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a  Number: ");
            int i = int.Parse(Console.ReadLine());
            //  int j = int.Parse(Console.ReadLine());
            /*  for( ; i <= 100; i++)
              {
                  Console.WriteLine(i);
              }
              Console.ReadLine();*/// 1 to 100 number serialwise print 
            /* for (; i<=20; i = i + 2)
             {
                 Console.WriteLine(i);

             }
             Console.ReadLine();*/
            /*  for ( ; i<= 10;++ i)
              {
                  for (int j=1 ; j<= i;++ j)
                  {
                      Console.Write("*");

                  }
                  Console.WriteLine();

              }

              Console.ReadLine();*/
            /*  for( ; i >= 1; i--)
              {
                  for (int j = 1; j<=i ; j++)
                  {
                      Console.Write("*");

                  }
                  Console.WriteLine();

              }

              Console.ReadLine();
          }*/
            for (; i <= 10; i++)
            {
                Console.WriteLine(10 * 10 * 10);
            }
            Console.ReadLine();
            
    }
    }
}