using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int count=0;
           
            do
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
                if (num * num * num > 100)
                              count++;
                i++;
            } while (i < 5);
            Console.WriteLine("countNumber" + count);
            Console.ReadLine();
        }
    }
}
