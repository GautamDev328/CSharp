using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_even_odd_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int even = 0, odd = 0;
            Console.Write("Enter size of array: ");
            int num = int.Parse(Console.ReadLine());
            int[] n = new int[num];
            int k = 0;
            while (k < num)
            {
                Console.Write("Enter number: ");
                n[k] = int.Parse(Console.ReadLine());
                k++;
            }
            int i = num - 1;
            while (i >= 0)

            {
                Console.WriteLine(n[i]);
                int j = 0;
                while (j < 1)
                {

                    if (n[i] % 2 == 0)

                        even++;
                    else
                        odd++;
                    j++;

                }
                i--;
            }
            Console.WriteLine("evennumber: " + even);
            Console.WriteLine("Odd Number: " + odd);
            Console.ReadLine();
        }
    }
}

/*Enter size of array: 5
Enter number: 34
Enter number: 33
Enter number: 43
Enter number: 43
Enter number: 2
2
43
43
33
34
evennumber: 2
Odd Number: 3
*/