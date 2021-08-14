using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSick
{
    class SchoolReceptionist
    {
     


        public SchoolReceptionist(Teacher teacher)
        {

            teacher.Teacher_Sick += AddTeacherLeave;
        }
    
        public void AddTeacherLeave(object sender,isSick e)
        {
            Teacher t1 = (Teacher)sender;
            Console.WriteLine("Teacher Name- {0} , Number of Days- {1} ",e.Teacher_Name,e.Number_of_days);   
        }
    }
}
