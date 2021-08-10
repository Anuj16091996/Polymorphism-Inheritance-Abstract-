using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Test_Concept;

namespace Student_Class
{
    class Student
    {

        /// <summary>
        /// Feilds
        /// </summary>
        //string first_name;
        //string last_name;
        //string course;
        //string subject;
        //string email;
        //long number=0;
       

        static int count = 0;

        public Student(string First_name, string Last_name)
        {
            count++;

            this.First_name = First_name;
            this.Last_Name = Last_name;
            this.Course = "Null";
            this.Subject = "null";
            this.Email = "Null";

        }

        public Student(string Course, string Subject,
            string First_name, string Last_name)
         : this(First_name, Last_name)
        {
            this.Course = Course;
            this.Subject = Subject;
        }


        public Student(String Email, long Phone_Number,
          string First_name, string Last_name,
               string Course, string Subject)
            : this(Course, Subject,First_name,Last_name)
        {
        
            this.Email = Email;
            this.Number = Phone_Number;

        }

        /// <summary>
        /// Properties
        /// </summary>
        /// <returns></returns>
        public static int number_objects()
        {
            return count;
        }

        public  String First_name
        {
            get;
            set;
        }

     

        public String Last_Name
        {
            get;
            set;
        }

        public string Course
        {
            get;
            set;
        }

        public String Subject
        {
            get;
            set;
        }

        public String Email
        {
            get;
            set;
        }

        public long Number
        {
            get;
            set;
        }



        public override string ToString()
        {
            return "First Name = " + First_name + "\n" +
                "Last Name= " + Last_Name + "\n" +
                "Course= " + Course + "\n" +
                "Subject =" + Subject + "\n" +
                "Email= " + Email + "\n" +
                "Number= " + Number + "\n" +
                "";  

            
        }


        ~Student()
        {
            
        }




    }
}
