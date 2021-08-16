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
       public Teacher(string name, int id)
        {
            this.Teacher_Name = name;
            this.ID = id;
        }
        
        public string Teacher_Name { get; set; }

        public int ID { get; set; }

        public List<Student> Students { get; set; }

        public void AddingStudnets(Student s1)
        {
            List<Student> Temp = new List<Student>();
            Temp.Add(s1);
            Students = Temp;
        }

       
       

        

    }
}
