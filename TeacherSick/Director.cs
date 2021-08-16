using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSick
{
    class Director
    {
        public string Name { get; set; }
        public Director( string name, SchoolReceptionist rec)
        {
            this.Name = name;
            rec.Teacher_Sick += AddTeacherLeave;
        }

        public void AddTeacherLeave(object sender, isSick e)
        {
     
            Console.WriteLine("Hello {0} , Your" +
                " School Teacher. Name- {1} will " +
                "be absent for  Number of Days- {2}",
                 this.Name, e.Teacher_Name
                , e.Number_of_days);
        }
    }
}
