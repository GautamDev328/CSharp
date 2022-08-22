using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heighestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num;
            int heighest = 0;
            do
            {
                Console.WriteLine("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                if (num >= heighest)
                    heighest = num;
                i++;
            } while (i < 5);
            Console.WriteLine("Highest Number :"+ heighest);
            Console.ReadLine();
        }
    }
}
