using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSick
{
    class Accountant
    {
        public string Name { get; set; }
        public Accountant(string name, SchoolReceptionist rec)
        {
            this.Name = name;
            rec.Teacher_Sick += AddTeacherLeave;
        }

        public void AddTeacherLeave(object sender, isSick e)
        {

            Console.WriteLine("\nHello {0} , Your" +
                " School Teacher. Name- {1} will " +
                "be absent for  Number of Days- {2} \n" +
                "Adjust this in her Pay-Cheque" +
                ", ID of Teacher is {3}",
                 this.Name, e.Teacher_Name
                , e.Number_of_days,e.ID);
        }
    }
}
