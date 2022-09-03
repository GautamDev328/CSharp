using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_program_use_in_get_and_set
{
    class Program
    {

        private int empNo;
        private string empName;
        private string mobile;
        public int EmpNo
        {
            set
            {
                empNo = value;
            }
            get
            {
                return empNo;
            }
        }
        public string EmpName
        {
            set
            {
                empName = value;
            }
            get
            {
                return empName;
            }
        }
        public string Mobile
        {
            set
            {
                mobile = value;


            }
            get
            {
                return mobile;
            }
        }
    }
}
