using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Classes : School
    {
        protected List<Student> students { get; set; }

        protected List<Teacher> Teachers { get; set; }

        protected List<Courses> Courses { get; set; }


    }
}