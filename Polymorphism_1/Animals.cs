using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_1
{
    abstract class Animals
    {
        public int Age { get; set; }

        public String Name { get; set; }

        public String Gender { get; set; }

       abstract public string Noise();



    }

   
}
