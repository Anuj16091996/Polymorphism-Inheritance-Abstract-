using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorOpen
{
    delegate EventHandler<DoorOpenEventArgs> Dooropen;
    class Door
    {
        public int ID { get; set; }

        bool isOpen;

        public bool IsOpen { get {return isOpen; }
            set 
            {
                this.isOpen = value;
                
            } 
        }
       

        public void Alaramon()
        {
            if(DoorOpenEvent!=null)
            {
                DoorOpenEvent?.Invoke();
            }
        }


    }
}
