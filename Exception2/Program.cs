using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exception2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArgumentNullException
            List<int> test1 = AppUtils.StringToListInt(null);



            //ArgumentException if we do
            List<int> test2 = AppUtils.StringToListInt("12,22,AB,ASDa");

        }
    }
}
