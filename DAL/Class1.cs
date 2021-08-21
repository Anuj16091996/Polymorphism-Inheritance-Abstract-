using Model_Exam;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Service
    {
        public static string filepath = "../../Account.txt";

        public static void AddBankAccount(Account ban)
        {


            string str = string.Format("{0)/{1}/{2}\n",
                ban.Account_Number, ban.Password, ban.Bank_Balance);


            File.AppendAllText(filepath, str);

        }

        public static List<Account> ReadAllAccount()
        {
            List<Account> acc = new List<Account>();

            string[] lines = File.ReadAllLines(filepath);

            foreach (var item in lines)
            {
                string[] data = item.Split('/');

                acc.Add(new Account()
                {
                    Account_Number = int.Parse(data[0]),
                    Password = data[1],
                    Bank_Balance = float.Parse(data[2])
                }
                );
            }



            return acc;
        }



        public static Account FindAccount(Account acc)
        {
            List<Account> acc1 = ReadAllAccount();

            Account acc2 = new Account();

            foreach (var item in acc1)
            {
                if (item.Account_Number == acc.Account_Number)
                {
                    if (item.Password == acc.Password)
                    {
                        acc2.Account_Number = item.Account_Number;
                        acc2.Password = item.Password;
                        acc2.Bank_Balance = item.Bank_Balance;


                    }
                }
            }

            return acc2;
        }


        public static void Updatdatabase(Account acc)
        {
            string[] lines = File.ReadAllLines(filepath);
            
            for(int i=0; i<lines.Length;i++)
            {
                string[] data = lines[i].Split('/');

                int accnum = int.Parse(data[0]);
                string password = data[1];
                float balance = float.Parse(data[2]);

                   if(accnum==acc.Account_Number 
                    && password==acc.Password)
                {
                    lines[i] = acc.ToString();
                }


            }
            File.WriteAllLines(filepath,lines);
        }

    }


}

