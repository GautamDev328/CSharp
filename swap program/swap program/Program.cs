using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("  Before  the progoram a= "+a+"b="+b);
            a = a * b;
            b = a / b;
            a = a / b;
           // b = a + b;
            Console.WriteLine("After the program a ="+a+"b ="+b);
            Console.ReadLine();
        }
       
    }
}
