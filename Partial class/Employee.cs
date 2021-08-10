using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_class
{
   partial class Employee 
    {
        public override string ToString()
        {
            return "First name -"+ this.First_name +"\n" +
                "Last Name - "+this.Last_Name + "\n" +
                "Birthday " +Birthday +"\n" +
                "SIN Num- "+SocialInsuranceNum ;
               
        }

        ~Employee()
        {

        }
    }
}
