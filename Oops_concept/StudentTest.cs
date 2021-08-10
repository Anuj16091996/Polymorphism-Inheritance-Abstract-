using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Class;

namespace Student_Test_Concept
{
    class StudentTest
    {
        static Student[] students=new Student[3];
        
        public static void Enterstudents()
        {
            students[0] =new Student("John", "Narang");
            students[1]=new Student("Parsa", "Rafie");
            students[2]=new Student("Rohit", "Pohit");
        }

        public static void print()
        {
         
            for( int i=0; i<students.Length;i++ )
            {
                Console.WriteLine(students[i].ToString());
            }


        }

        public static string FirstName(Student stu)
        {
            return stu.First_name;
        }

        public static string Lastname(Student stu)
        {
            return stu.Last_Name;
        }
        
        public static string Course(Student stu)
        {

            return stu.Course;
        }
    }
}
