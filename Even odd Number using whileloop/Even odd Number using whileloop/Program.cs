using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_odd_Number_using_whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ctrl = 0;
            int num;
            int Even = 0;
            int odd = 0;
            while(ctrl< 5)
            {
                Console.WriteLine("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                    Even++;
                else
                    odd++;

                ctrl++;

            }
            Console.WriteLine("showEvenNumber Result :"+Even);
            Console.WriteLine("showOddNumber Result:" + odd);
            Console.ReadLine();
        }
    }
}
