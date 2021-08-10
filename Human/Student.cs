using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Student :Human
    {
        public int Mark { get; set; }

        public override float CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
