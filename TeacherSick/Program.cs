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
            Teacher t1 = new Teacher("Ritu",12);
            SchoolReceptionist s1 = new SchoolReceptionist(t1,12);
            Director d1 = new Director("John",s1);
            Accountant a1 = new Accountant("Rama",s1);

            List<Student> stus = new List<Student>();
            Student stu1 = new Student(1,"Anuj","Narang");
            Student stu2 = new Student(2,"Parsa","Rafie");


            stus.Add(stu1);
            stus.Add(stu2);

            Student register = new Student(stus,s1);
            s1.Teacher_Sicks();
;        }
    }
}
