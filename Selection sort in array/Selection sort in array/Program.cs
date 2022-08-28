using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 10, 5, 2, 6, 1 };
            int i = 0;
            int j;
            int temp = 0;
            while (i < 5)
            {
                j = i + 1;
                while (j < 5)
                {
                    if (ar[i] > ar[j])
                    {
                        temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;

                    }
                    j++;
                }
                i++;
            }
            Console.ReadLine();
        }

    }
}