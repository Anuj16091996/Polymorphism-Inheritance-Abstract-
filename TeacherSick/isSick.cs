using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherSick
{
    class isSick:EventArgs
    {
        public string Teacher_Name { get; set; }

        public int Number_of_days { get; set; }

        public int ID { get; set; }

        public isSick(string name, int days, int id)
        {
           this.Teacher_Name = name;
            this.Number_of_days = days;
            this.ID = id;
        }
    }
}
