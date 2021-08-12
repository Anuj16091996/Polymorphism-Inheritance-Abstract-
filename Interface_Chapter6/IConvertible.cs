using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Chapter6
{
    interface IConvertible
    {
         string ConvertToCSharp(string user);

        string ConvertToVB(string user);
    }
}
