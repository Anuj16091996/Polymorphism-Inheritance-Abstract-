using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Chapter6
{
    class Test
    {
        public static void main()
        {
            string test = "I am typing C# Code and the code is in C# and vb";
            string test2 = "I AM Typing VB and the code is in VB and VB Code";
            string use="";

            ProgramHelper p1 = new ProgramHelper();

            p1.ConvertToVB(test);

            p1.ConvertToCSharp(test2);

            p1.CodeCheckSyntax(test, use);


            p1.CodeCheckSyntax(test2,use);


        }
    }
}
