using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{

        delegate string DGSaySomething(String value);
    class Program
    {
        static void Main(string[] args)
        {
            

            DGSaySomething Dg = new DGSaySomething(new Chinese().SaySomething);
            Console.WriteLine( Dg.Invoke("Nihao"));
        }
    }
}
