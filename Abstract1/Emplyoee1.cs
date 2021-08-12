using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1
{
    class Emplyoee1 : Employee
    {

        public Emplyoee1(string name, float salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public override float GetMonthlySalary()
        {
            return base.Salary /12;
        }

        ~Emplyoee1()
        {

        }
    }
}
