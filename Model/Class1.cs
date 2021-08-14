using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        public int Stu_ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

         static int number=0;

     


        public override string ToString()
        {
            number++;

            return "Student "+number +"\n" +
                ""+"Name- " +this.Name+"\n" +
                "Age-  "+this.Age +"\n" +
                "Student ID- " + this.Stu_ID+"\n" +
                "";

           
        }

    }
}
