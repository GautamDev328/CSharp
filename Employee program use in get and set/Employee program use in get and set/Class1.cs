using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_program_use_in_get_and_set
{
    class Class1
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.EmpNo = 101;
            p.EmpName = "Gautam";
            p.Mobile = "8409844260";
            Console.WriteLine("number: "+p.EmpNo);
            Console.WriteLine("name :"+p.EmpName);
            Console.WriteLine("name :"+p.Mobile);
            Console.ReadLine();
        }
    }
}
