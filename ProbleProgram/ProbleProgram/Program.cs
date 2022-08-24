using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbleProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 11;
            while (i <= 21)
            {
                if (i != 15)
                {
                    Console.WriteLine(i);
                }
                i = i + 2;
            }
            Console.ReadLine();

        }
     
    }
}
/* Output:
  11
13
17
19
21
*/
