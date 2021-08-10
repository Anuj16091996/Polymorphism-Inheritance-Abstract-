using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Teacher : Classes
    {
        protected List<Courses> Course;

        public String Teacher_Name { get; set; }
    }
}