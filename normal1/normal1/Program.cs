using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace normal1
{
    public class Program
    {
        static void see(int x, string y)
        {
            Console.WriteLine(x+" "+y);
        }
        static void see(string y, int x)
        {
            Console.WriteLine(x+" "+y);
        }
       public  static void Main(string[] args)
        {
            Program.see(102, "Ram");
            Program.see("shyam", 103);
            Console.ReadLine();
           
;        }
    }
}
