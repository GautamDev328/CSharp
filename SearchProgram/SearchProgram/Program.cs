using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Array seial Number :");
            int[] ar = { 1, 3, 5, 4, 6, 8, 7 };
            int i = 0;
            while (i < ar.Length)
            {
                Console.Write(" " + ar[i]);
                i++;
            }
            Console.WriteLine();
            Console.Write("Enter the search values:");
            int search = int.Parse(Console.ReadLine());
            bool flag = false;
            int j = 0;
            // int j = 0;
            while (j < ar.Length)
            {
                if (search == ar[j])
                {
                    flag = true;
                    break;
                }
                j++;
            }
            if (flag == true)

                if (search % 2 == 0)
                    Console.WriteLine("Even Number : " + search);
                else
                    Console.WriteLine("odd Number: " + search);

            else
                Console.WriteLine("Number is not found ");


             
            Console.ReadLine();
        }
    }
}
/* Output:
  Array seial Number : 1 3 5 4 6 8 7
Enter the search values:5
odd Number: 5

*/


