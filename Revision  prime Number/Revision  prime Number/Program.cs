using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision__prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int prime = 0;
            int notprime = 0;
            while (i <=5)
            {
                Console.WriteLine("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                int j = 1;
                while (j < num / 2)
                {
                    if (num % 2 == 0)
                    {
                        notprime++;
                        break;

                    }
                    else
                    {
                        prime++;
                        break;
                    }
                    j++;
                }
                i++;


            }
            Console.WriteLine("Not prime :"+ notprime );
            Console.WriteLine("Prime: "+ prime);
            Console.ReadLine();
            }
        }
    }
/* output:
 * Enter a number:
21
Enter a number:
12
Enter a number:
15
Enter a number:
24
Enter a number:
15
Not prime :2
Prime: 3



*/