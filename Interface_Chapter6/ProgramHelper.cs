using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Chapter6
{
    class ProgramHelper : IConvertible,ICodeChecker 
    {
        public bool CodeCheckSyntax(string check, string use)
        {
            bool status = true;

            if(check.Contains("C#"))
            {
                use = "User Is Using C# Language";
                Console.WriteLine(use);
                status = true;
            }

            else if(check.Contains("VB"))
            {
                use = "User Is Using VB Language";
                Console.WriteLine(use);
                status = true;
            }

            else
            {
                status = false;
            }


            if(status==false)
            {
                Console.WriteLine("User Is Not Using C# Or VB");
            }


            return status;
        }

        public string ConvertToCSharp(string user)
        {
            

            if(user.Contains("VB") )
                Console.WriteLine( user.Replace("VB", "C#"));

            else
            Console.WriteLine(user);

            return user;
        }

        public string ConvertToVB(string user)
        {
            if (user.Contains("C#"))
                Console.WriteLine(user.Replace("C#", "VB"));

            else
                Console.WriteLine(user);

            return user;
        }
    }
}
