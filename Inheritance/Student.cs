using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : Classes
    {
        public int Unique_Number { get; set; }

        public string Name { get; set; }

        protected List<Courses> Courses;
    }
}
