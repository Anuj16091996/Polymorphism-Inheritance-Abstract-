using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionarys
{
    class BankAccount
    {
        public BankAccount(double balance)
        {
            this.Account_Balance = balance;
        }


        public double Account_Balance { get; set; }
    }
}
