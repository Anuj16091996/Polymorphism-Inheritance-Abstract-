using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Worker : Human
    {
        public Worker(float rate, float hours)
        {
            this.Rate = rate;
            this.Hours_Worked = hours;
        }

       public float Rate { get; set; }

        public float Hours_Worked { get; set; }

        public override float CalculateSalary()
        {
            return Rate * Hours_Worked;
        }
    }
}
