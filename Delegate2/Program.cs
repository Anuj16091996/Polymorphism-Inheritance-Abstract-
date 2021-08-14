using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog jack = new Dog();

            Owner1 o1 = new Owner1("Anuj",jack);
            Owner2 o2 = new Owner2("Hamza", jack);

            jack.HostOwner();

            jack.Alaram -= o2.AlaramOnCheck;
            jack.HostOwner();
        }
    }
}
