using DAL;
using Model_Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class AccountManager
    {
       

        public static float Depsoit(Account ban, float money)
        {
            return ban.Deposit(money);
        }

        public static float WithDraw(Account ban, float money)
        {
            return ban.Withdraw(money);
        }

        public static Account LoginCheck(Account acc)
        {
            return Service.FindAccount(acc);
        }

       public static void Updatedatabase(Account acc)
        {
            Service.Updatdatabase(acc);
        }

    }

}


