using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_even_and_odd___using_Do_in_array_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n= { 1, 2, 3, 5, 6, 7, 9, 11, 15 };
            int k = 0;
            Console.Write("Enter a seial Array Number: ");
            while (k< n.Length)
            {
                Console.Write(n[k] +" ");
                k++;
            }
            Console.WriteLine(" ");

            Array.Reverse(n);
            //   Console.WriteLine(String.Join(n)); 
            Console.Write("Enter a Reverse Array Number: ");
            int j = 0;
            while (j < n.Length)
            {
                Console.Write(n[j]+" ") ;
                j++;
            }




           
            Console.WriteLine(" ");
            Console.Write("Enter a total Number: ");
        Console.Write(n.Length);
            Console.WriteLine();
            int i = 1;
            int even = 0;
            int odd = 0;
            while (i <= 9)
            {
                if (i % 2 == 0)
                    even++;
                else
                    odd++;
                i++;



            }
            Console.WriteLine("Even Number: " + even);
            Console.WriteLine("odd Number:" + odd);

            Console.ReadLine();

        }

    }
}
/* output:
  Enter a seial Array Number: 1 2 3 5 6 7 9 11 15
Enter a Reverse Array Number: 15 11 9 7 6 5 3 2 1
Enter a total Number: 9
Even Number: 4
odd Number:5

*/

