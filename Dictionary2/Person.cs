using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2
{
    class Person
    {
        public Person(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public int ID { get; set; }

        public string Name { get; set; }
    }
}
