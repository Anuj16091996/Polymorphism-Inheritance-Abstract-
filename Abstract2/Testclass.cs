using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    class Testclass
    {
        public static void started()
        {
            USBDisk us = new USBDisk();
            SmartPhone sp = new SmartPhone();


            Computer c1 = new Computer();

            c1.ReadData(us);
            c1.WriteData(us);


            c1.ReadData(sp);
            c1.WriteData(sp);


        }

        ~Testclass()
        {

        }
    }
}
