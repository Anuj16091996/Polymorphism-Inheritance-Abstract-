using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
  abstract class StorageDevice
    {
        public abstract string Read();

        public abstract string Write();


        ~StorageDevice()
        {

        }
    }
}
