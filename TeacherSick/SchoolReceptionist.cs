using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSick
{
    class SchoolReceptionist
    {

        public event EventHandler<isSick> Teacher_Sick;
        public string Teacher_Name { get; set; }

        public int Number_of_days { get; set; }

        public int ID { get; set; }

        public SchoolReceptionist( Teacher name,int days)
        {
            Teacher_Name=name.Teacher_Name;
            this.Number_of_days = days;
            this.ID = name.ID;
      
        }

        public void Teacher_Sicks()
        {
            if (Teacher_Sick != null)
            {
           
                Teacher_Sick(this, new isSick(this.Teacher_Name, Number_of_days,ID));
            }
        }



        
    }
}
