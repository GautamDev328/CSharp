using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a array: ");
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a];
            int i = 0;
            int sum = 0;

            while (i <a)
            {
                Console.WriteLine("Ener a number :");
                b[i] = int.Parse(Console.ReadLine());
                sum = sum + b[i];
                i++;
            }
            Console.WriteLine("sum of array :"+ sum);
            Console.ReadLine();


        }
    }
}
/* output:
Enter a array: 5
Ener a number :
4
Ener a number :
2
Ener a number :
3
Ener a number :
1
Ener a number :
2
sum of array :12

*/