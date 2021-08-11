using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    class Person
    {
        public string UseKitchenAppliance(KitchenAppliance ka)
        {
            return ka.PowerOn();
        }
    }
}
