using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_by_value_parameter_program
{
    class Program
    {
        static void show( int x, int y)
        {
            int z = x;
            x = y;
            y = z;

        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine(x+" "+y);
            show(x, y);
            Console.WriteLine(x+" "+y);
            Console.ReadLine();
        }
    }
}
