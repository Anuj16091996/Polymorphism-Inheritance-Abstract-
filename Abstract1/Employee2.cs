using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1
{
    class Employee2:Employee
    {
        public Employee2(string name, float salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public override float GetMonthlySalary()
        {
            return base.Salary/12;
        }

        ~Employee2()
        {

        }
    }
}
