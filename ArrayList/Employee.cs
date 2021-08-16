using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_List
{
    class Employee:Person
    {
        public double Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            base.Name = name;
            base.Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Employee Name- " + base.Name + "\n" +
               "Employee Age- " + base.Age + "\n" +
               "Employee Number" + this.Salary + "\n" +
               " \n";
        }
    }
}
