using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Class;
using Student_Test_Concept;

namespace Oops_concept
{
    class Program
    {
        static void Main(string[] args)
        {

            Student st1 = new Student("John", "Narang");
            Student st2 = new Student("Parsa", "Rafie");
            Student st3 = new Student("Rohit", "Pohit");
            Student st4 = new Student("Video-Game", "OOPS", "Dev", "Kumar");
            Student st5 = new Student("anuj161996@gmail.com", 76387638767812, "Rohit", "Kumars", "Video-Game", "OOPS");


            ////Add a static field for the class Student,
            ////which holds the number of created objects of this class.

            //Console.WriteLine(Student.number_objects());

            ////Add a method in the class Student,
            ////which displays complete information about the student
            //Console.WriteLine(st5);
            //Console.WriteLine(st4);
            //Console.WriteLine(st2);


            //Testing case for Student_test
            /////
            //Console.WriteLine(StudentTest.FirstName(st1));
            //Console.WriteLine(StudentTest.Lastname(st1));
            //Console.WriteLine(StudentTest.Course(st1));

            StudentTest.Enterstudents();
            StudentTest.print();



        }
    }
}
