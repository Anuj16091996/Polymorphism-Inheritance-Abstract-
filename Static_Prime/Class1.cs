using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Prime
{
    class Class1
    {
        public static List<int> GetPrimes(int start, int end)
        {
            List<int> prime = new List<int>();

            for(int i=start; i<end;i++)
            {
                if(i%2!=0)
                {
                    prime.Add(i);
                }
            }
           

            return prime;
        }
    }
}
