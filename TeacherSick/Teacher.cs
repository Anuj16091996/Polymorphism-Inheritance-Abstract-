using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSick
{
    //delegate void isSick();


    class Teacher
    {
        public event EventHandler<isSick> Teacher_Sick;
        public Teacher(string name, int days)
        {
            this.Teacher_Name = name;
            this.Number_of_days = days;
        }

        public string Teacher_Name { get; set; }

        public int Number_of_days { get; set; }

        public List<Student> Students { get; set; }

        public void AddingStudnets(Student s1)
        {
            List<Student> Temp = new List<Student>();
            Temp.Add(s1);
            Students = Temp;
        }

       
        public void Teacher_Sicks()
        {
            if(Teacher_Sick!=null)
            {
                Teacher_Sick(this, new isSick(Teacher_Name,Number_of_days));
            }
        }

        

    }
}
