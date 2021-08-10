using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w1 = new Worker(12,23);
      

            Console.WriteLine(w1.CalculateSalary());
            
        }
    }
}
