using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception3
{
    class Student
    {
        public Student(int id, string fname, string lname, string gen, int age)
        {
            this.Id = id;
            this.First_Name = fname;
            this.Last_Name = lname;
            this.Gender = gen;
            this.Age = age;
        }

        public int Id { get; set; }
        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Gender { get; set; }

        public int Age
        {
            get
            {
                return Age;
            }

            set
            {
                if(value>100 || value <16)
                {
                    throw new StudentAgeException("Age can not be " + value);
                }
            }
        }

    }
}
