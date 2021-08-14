using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

 
    class Program
    {

     
    static void Main(string[] args)
        {


            DigiTest test = new DigiTest(new Test_pro().Fname); ;
            test += Test_pro.Banme;
            test.Invoke();

            test -= new Test_pro().Fname;
            test.Invoke();

            test = new Test_pro().Fname;
            test.Invoke();



        }
    }
}
