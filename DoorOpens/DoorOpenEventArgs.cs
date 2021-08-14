using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorOpens
{
    class DoorOpenEventArgs:EventArgs
    {
        public DateTime Time { get; set; }
        public DoorOpenEventArgs(DateTime time)
        {
            this.Time = time;

        }

    
    }
}
