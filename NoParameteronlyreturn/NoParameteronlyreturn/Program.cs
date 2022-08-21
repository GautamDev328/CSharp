using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoParameteronlyreturn
{
    class Program
    {
        static string print()
        {
            string res;
            Console.Write(" Enter the Number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                res = "Number  is Even";
            else
                res = "Number  is Odd";
            return res;
        }
        static void Main(string[] args)
        {
            string s = print();
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}