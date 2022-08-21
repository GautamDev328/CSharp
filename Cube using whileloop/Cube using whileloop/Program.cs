using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_using_whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ctrl = 0;
            int num;
            int count = 0;
            while (ctrl < 5)
            {
                Console.WriteLine("Enter a Number:" );
                num = int.Parse(Console.ReadLine());
                if (num * num * num > 100)
                    count++;
                ctrl = ctrl + 1;
            }
            Console.WriteLine("cube : "+ count );
            Console.ReadLine();
        }
    }
}
