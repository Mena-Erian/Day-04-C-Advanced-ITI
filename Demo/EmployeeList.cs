using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class EmployeeList : List<Employee>
    {
        public new void Add(Employee emp)
        {
            if (!emp.Name.Contains("s")) base.Add(emp);
            else Console.WriteLine($"Your {emp} Not Valid To Add in List");
        }
    }
}
