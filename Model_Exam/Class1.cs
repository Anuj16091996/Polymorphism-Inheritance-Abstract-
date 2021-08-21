using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Exam
{
    public class Account
    {
        public int Account_Number { get; set; }

        public string Password { get; set; }

        public float Bank_Balance { get; set; }

        public  float Deposit(float money)
        {
            return Bank_Balance += money;
        }

        public float Withdraw(float money)
        {
            return Bank_Balance -= money;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}",Account_Number,
                Password,Bank_Balance)
                ;
        }


    }
}
