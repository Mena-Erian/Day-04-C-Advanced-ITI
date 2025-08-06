using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class InvalidEmployeeValidData : Exception
    {
        Employee emp;
        public InvalidEmployeeValidData(string message, Employee emp) : base(message)
        {
            this.emp = emp;
        }
    }
}
