using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    class SmartPhone:StorageDevice
    {
        public override string Read()
        {
            return "Reading Through SmartPhone";
        }

        public override string Write()
        {
            return ("Typing Through SmartPhone");
    
          
        }

        ~SmartPhone()
        {

        }
    }
}
