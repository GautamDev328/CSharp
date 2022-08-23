using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_program_using_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];

            ar[0] = 101;
            ar[1] = 102;
            ar[2] = 103;
            ar[3] = 104;
            ar[4] = 105;
            //int i ;
            for( int i=0; i <= 4; i++)
            {
                Console.WriteLine(ar[i]);
               
            }
            Console.ReadLine();
        }
    }
}
/* Output:
 * 101
102
103
104
105

*/
