using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2
{
    class BankAccount
    {
      public  static int num = 0;
        public BankAccount(float acc)
        {
           
            this.Account_Balance = acc;
 
        }

        public float Account_Balance { get; set; }
    }
}
