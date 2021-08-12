using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1
{
    abstract class Employee
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public float Salary { get; set; }

        public abstract float GetMonthlySalary();


        ~Employee()
        {

        }

    }
}
