using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSick
{
    class Student
    {
        public List<Student> Students { get; set; }
        public Student(List<Student> students,SchoolReceptionist rec)
        {
            this.Students = students;
            rec.Teacher_Sick += AddTeacherLeave;
        }

        public Student(int id,string fname, string lname)
        {
            this.Stud_Id = id;
            this.First_Name = fname;
            this.Last_Name = lname;
        }

        public void AddingStudnets(Student s1)
        {
            List<Student> Temp = new List<Student>();
            Temp.Add(new Student(s1.Stud_Id,s1.First_Name,s1.Last_Name));
            Students = Temp;
        }

        public int Stud_Id { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public long Phone_Number { get; set; }

        public void AddTeacherLeave(object sender, isSick e)
        {
           

           for(int i=0; i<Students.Count;i++)
            { 
            Console.WriteLine("\nHello {0} , Your" +
                " School Teacher. Name- {1} will " +
                "be absent for  Number of Days- {2} " +
                "Enjoy Your Vacation ",
                 Students[i].First_Name, e.Teacher_Name
                , e.Number_of_days);
            }
        }

    }
}
