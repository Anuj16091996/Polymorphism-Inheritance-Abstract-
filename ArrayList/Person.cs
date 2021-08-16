using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arrays_List
{
    abstract class Person
    {
        public static ArrayList arr = new ArrayList();
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract override string ToString();
       
    }
}
