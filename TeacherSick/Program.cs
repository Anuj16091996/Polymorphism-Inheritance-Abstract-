using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSick
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Qwe",12);
            SchoolReceptionist s1 = new SchoolReceptionist(t1);


            t1.Teacher_Sicks();
;        }
    }
}
