using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorOpens
{
    class SafetyGuard
    {
        public string Name { get; set; }
        public SafetyGuard(string name,Door door)
        {
            this.Name = name;
            door.alarmOn += AlaramForDoor;
        }

        public void AlaramForDoor(object sender,DoorOpenEventArgs e)
        {
            Console.WriteLine("{0} Door is Open at {1} ",this.Name,e.Time);
        }


    }
}
