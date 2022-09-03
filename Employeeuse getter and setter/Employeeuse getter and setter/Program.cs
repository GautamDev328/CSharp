using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeuse_getter_and_setter
{
    class Program
    {
        private int empno;
        private string empname;
        private string    emobile;
        public void setempno(int empno)
        {
           this. empno = empno;
        }
        public void setempname(string empname)
        {
            this.empname = empname;
        }
        public void setemobile(string   emobile)
        {
            this.emobile = emobile;
        }
        public int getempno()
        {
            return this.empno;
        }
        public string getempname()
        {
            return this.empname;
        }
        public string  getemobile()
        {
            return this.emobile;
        }
       
    }
}
