using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_List
{
    class Student : Person
    {

        public Student(string name, int age, int num)
        {
            base.Name = name;
            base.Age = age;
            StuNumber = num;
        }



        readonly int StuNumber;

        public override string ToString()
        {
            return "Student Name- "+ base.Name+"\n" +
                "Student Age- " +base.Age +"\n" +
                "Student Number -" + this.StuNumber+"\n" +
                " \n";
        }
    }
}