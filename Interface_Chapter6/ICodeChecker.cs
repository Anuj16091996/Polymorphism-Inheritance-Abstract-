using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Chapter6
{
    interface ICodeChecker
    {
        bool CodeCheckSyntax(string check, string use);
    }
}
