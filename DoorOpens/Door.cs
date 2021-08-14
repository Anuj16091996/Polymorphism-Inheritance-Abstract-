using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorOpens
{
    class Door
    {
        public event EventHandler<DoorOpenEventArgs> alarmOn;


        public int ID { get; set; }

        bool isOpen;
        bool? ifitscloos=null;

        public bool IsOpen
        {
            get
            { return isOpen; }
            set
            {

                if (value == true & ifitscloos != true)
                {
                   
                    if (alarmOn != null)
                    {
                        ifitscloos = true;
                        DoorOpenEventArgs d1 = new DoorOpenEventArgs(DateTime.Now);
                        alarmOn(this, d1);
                    }

                }

                else if(value==false & ifitscloos!=false )
                {
                    ifitscloos = false;
                    Console.WriteLine("Door is Closed");

                }
            }
        }




    }
}
