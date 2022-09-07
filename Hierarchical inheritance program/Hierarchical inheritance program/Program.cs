using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_inheritance_program
{
    class Program
    {
        protected void show()
        {
            Console.WriteLine("father");

        }

        class Demo : Program
        {
            public void show1()
            {
               show();
                Console.WriteLine("chile-1");
            }
        }
        class System : Demo
        {
            public void show1()
            {
                show();
                Console.WriteLine("child-2");
            }


        }
        class Mummy
        {

            static void Main(string[] args)
            {
                Demo d = new Demo();
                System s = new System();
                d.show1();
                s.show1();
                Console.ReadLine();
            }
        }
    }

}