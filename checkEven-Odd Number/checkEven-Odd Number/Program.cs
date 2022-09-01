using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkEven_Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 101, 102, 103, 104 };
            int i = 0;
            Console.Write("Enter a serialwise array: ");
            while (i < n.Length)
            {

                Console.Write(n[i] + " ");
                i++;
            }
            Console.WriteLine("  ");
            Array.Reverse(n);
            Console.Write("Enter a Reverse array number:  ");
            int j = 0;
            while (j < n.Length)
            {
                Console.Write(n[j] + " ");
                j++;
            }
            Console.WriteLine(" ");
            Console.Write("Enter a total array number :");
            //  int k = 0;
            Console.Write(n.Length);
            Console.WriteLine(" ");
            Console.WriteLine("Enter the check  Even odd number :  ");
            int k = 1;
            int even = 0;
            int odd = 0;
            while (k <= 4)
            {
                if (k % 2 == 0)

                    even++;


                else
                    odd++;
                k++;
            }
            Console.WriteLine(" Even Number: " + even);
            Console.WriteLine("Odd Number: " + odd);



            Console.ReadLine();
        }

    }
}
/* Output: 
Enter a serialwise array: 101 102 103 104
Enter a Reverse array number:  104 103 102 101
Enter a total array number :4
Enter the check  Even odd number :
 Even Number: 2
Odd Number: 2
*/
      