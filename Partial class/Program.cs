using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Anuj","Narang",DateTime.Now,098098098098);

            Console.WriteLine(e1.ToString());
        }
    }
}
