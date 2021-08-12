using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    class USBDisk : StorageDevice
    {


        public override string Read()
        {
            return "Reading Through USB-Disk";
        }

        public override string Write()
        {
            return ("Typing Through USB-Disk");
           
            }

        ~USBDisk()
        {

        }
    }
}
