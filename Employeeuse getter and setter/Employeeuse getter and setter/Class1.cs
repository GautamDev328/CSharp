using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeuse_getter_and_setter
{
    class Class1
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.setempno(101);
            p1.setempname("gaurav");
            p1.setemobile("8409844260");

            Console.WriteLine("number is :"+p1.getempno());
            Console.WriteLine("Name is: "+p1.getempname());
            Console.WriteLine("mobile is: "+p1.getemobile());
            Console.ReadLine();


        }
    }
}
