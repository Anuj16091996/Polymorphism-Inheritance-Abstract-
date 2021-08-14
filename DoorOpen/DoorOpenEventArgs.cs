using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorOpen
{
    class DoorOpenEventArgs:EventArgs
    {
        public DateTime Time { get; set; }

        DoorOpenEventArgs(DateTime time)
        {
            this.Time = time;
        }
    }
}
