using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace normalprogram
{
   public  class Program
    {
        public void sum(int x, string y)
        {
            Console.WriteLine(x +" "+ y);
        }
        public void sum(string x, int y)
        {
            Console.WriteLine(x+" "+y);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.sum(10, "Ram");
            p.sum("sum", 20);
            Console.ReadLine();
        }
    }
}
