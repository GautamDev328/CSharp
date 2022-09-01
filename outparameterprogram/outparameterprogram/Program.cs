using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outparameterprogram
{
    public class Program
    {
        public static void Display(int x, int y, out int sum, out int sub, out int Mult, out int Div)
        {
            sum = x + y;
            sub = x - y;
            Mult = x * y;
            Div = x / y;
        }
        static void Main(string[] args)
        {

            int sum, sub, Mult, Div;
     
        Display(20 , 10, out  sum, out  sub, out  Mult, out Div);
            Console.WriteLine("sum :" + sum);
            Console.WriteLine("sub:"+ sub);
            Console.WriteLine("Mult:"+Mult);
            Console.WriteLine("Div:"+Div);
            Console.ReadLine();
    
      
        
        }
    }
}
