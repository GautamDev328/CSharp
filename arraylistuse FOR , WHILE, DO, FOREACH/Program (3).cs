using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprogram_using_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            ar[0] = 201;
            ar[1] = 202;
            ar[2] = 203;
            ar[3] = 204;
            ar[4] = 205;
            int i = 0;
            do
            {
                Console.WriteLine(ar[i]);
                i++;

            } while (i <= 4);
            Console.ReadLine();

        }
    }
}
/* output:
 201
202
203
204
205
*/
