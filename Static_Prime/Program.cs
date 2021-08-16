using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Prime
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> data = Class1.GetPrimes(12,23);

            foreach (int i in data)
            {
                Console.WriteLine("{0} is a prime number",i);
            }
           
        }
    }
}
