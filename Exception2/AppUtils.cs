using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exception2
{
    static class AppUtils
    {
        static public List<int> StringToListInt(string message)
        {
            List<int> data = new List<int>();

            if (message == null)
            {
                ArgumentNullException args = new ArgumentNullException(message,
                    "Parameter Null Exception");
                throw args;

            }

            if (Regex.IsMatch(message, "[a-zA-Z]"))
            {
                ArgumentException aags = new ArgumentException(message,"Parameter " +
                    "String Arhument");

                throw aags;
            }
        
            return data;
        }
    }
}
