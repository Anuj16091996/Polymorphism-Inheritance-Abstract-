using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> Values= new List<BankAccount>();
            Values.Add(new BankAccount(1234));
            Values.Add(new BankAccount(12345));
            Values.Add(new BankAccount(123456));



            Dictionary<Person, List<BankAccount> > dict = new Dictionary<Person, List<BankAccount>>();

            dict.Add(new Person(1,"Anuj"),Values );
            dict.Add(new Person(2, "John"), Values);

        

            foreach(var re in  dict)
            {
                KeyValuePair<Person,List<BankAccount> > de= (KeyValuePair<Person,List<BankAccount>>) re;

               
                  Console.WriteLine("ID= "+de.Key.ID+" "
                      +" Name= "+de.Key.Name +" Account Balance= "+" "+de.Value[BankAccount.num].Account_Balance);

                BankAccount.num++;
        
            }



        }
    }
}
