using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_class
{
    partial class Employee
    {

        public Employee(String firstname,String lastname,
            DateTime birthday, long sin_num)
        {
            this.First_name = firstname;
            this.Last_Name = lastname;
            this.Birthday = birthday;
            this.SocialInsuranceNum = sin_num;
        }

        public string First_name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Birthday { get; set; }
       public long SocialInsuranceNum { get; set; }



    }
}
