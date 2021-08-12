using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    class Computer
    {
        public void ReadData(StorageDevice device)
        {
            Console.WriteLine(device.Read());
        }


        public void WriteData(StorageDevice device)
        {
            Console.WriteLine(   device.Write());
        }

        ~Computer()
        {

        }
    }
}
