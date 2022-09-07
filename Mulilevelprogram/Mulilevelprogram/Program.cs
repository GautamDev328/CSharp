using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulilevelprogram
{
    class Program
    {
        protected       void show()
        {
            int a = 20;
            int b = 30;
            //  int c = a + b;
            // Console.WriteLine( "grandfather: " + (a + b));
            // Console.WriteLine("grandfather");
            Console.WriteLine((a+b));
        }
        class Demo : Program
        {
            protected     void show1() { 
     

                // int a = 20;
                // int b = 30;
                //Console.WriteLine("father: " + (a - b));

               show();
                //  show();
                //  Console.WriteLine("father");
                //  show();
                //     Console.WriteLine("father: "  +( a + b));
                //Console.WriteLine(a+b);
                //  Console.WriteLine(c);
                ///  Console.WriteLine("Papa ji");

            }
            class Mix : Demo
            {
                 protected  void shown()
                {
                     show();
                  
                 show1();
                    show();

                    //int a = 20;
                    //int b = 30;
                    //Console.WriteLine("child: " + (a *b));

                }
              public   static void Main()
                {
                    Mix m = new Mix();
                    m.shown();
                    Console.ReadLine();


                }
            }
        }
    }
}
