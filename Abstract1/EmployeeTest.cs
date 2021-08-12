using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1
{
    class EmployeeTest
    {
        public static void started()
        {
            Employee2 e2 = new Employee2("Anuj",12763897);
            Emplyoee1 e1=new Emplyoee1("Rohit",1200);

            Console.WriteLine( e2.GetMonthlySalary());
            Console.WriteLine( e1.GetMonthlySalary());


        }


        ~EmployeeTest()
        {

        }
    }
}
