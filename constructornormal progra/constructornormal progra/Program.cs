using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructornormal_progra
{
   public  class Program
    {
        public void sum()
        {
            Console.WriteLine("Hi");
        }
        public void sum(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public void sum(int x, int y , int z)
        {
            Console.WriteLine(x+y+z);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.sum();
            p.sum(20, 10);
            p.sum(20, 10, 5);
            Console.ReadLine();
                
        }
    }
}
