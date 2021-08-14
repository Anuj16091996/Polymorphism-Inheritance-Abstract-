using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorOpens
{
    class Program
    {
        static void Main(string[] args)
        {
            Door d1 = new Door();
            SafetyGuard s1 = new SafetyGuard("Parsa",d1);
            Owner o1 = new Owner("Anuj",d1);

       
            d1.IsOpen = true;

            d1.IsOpen = false;






        }
    }
}
