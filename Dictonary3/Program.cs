using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonary3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Person, BankAccount> dict = new Dictionary<Person, BankAccount>();

            dict.Add(new Person(1, "Anuj"), new BankAccount(12234));
            dict.Add(new Person(2, "Rohit"), new BankAccount(134));
            dict.Add(new Person(3, "Luigi"), new BankAccount(1334));

            foreach (var re in dict)
            {
                KeyValuePair<Person, BankAccount> de = (KeyValuePair<Person, BankAccount>)re;

                Console.WriteLine("ID= "+de.Key.ID +" Name= "+de.Key.Name
                    +" Balance =" +de.Value.Account_Balance);
            }





        }
    }
}
