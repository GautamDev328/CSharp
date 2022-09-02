using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_programs
{
    class Program
    {
        public int x = 10;
        public int y = 20;
        public void sum()
        {
            Console.WriteLine("sum:" +( x + y));
        }
        public void sub()
        {
            Console.WriteLine("sub:" + (x - y));
        }
    }
    class Demo { 
        static void Main(string[] args)
        {
            Program p = new Program();
            p.sum();
            p.sub();
           

          
            Console.WriteLine("Add: "+ (p.x+p.y));
            Console.WriteLine("minus: "+ (p.x - p.y));
            Console.WriteLine("miult: "+(p.x *p.y));
            Console.WriteLine("Div: " + (p.x / p.y));
            Console.ReadLine();

        }
    }
}
//sum: 30
//sub: -10
//Add: 30
//minus: -10

