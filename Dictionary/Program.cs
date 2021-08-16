using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<Person, BankAccount> dict = new Dictionary<Person,BankAccount>();

            dict.Add(new Person(1,"Anuj"), new BankAccount(12345));
            dict.Add(new Person(2, "John"), new BankAccount(1234));
            dict.Add(new Person(3, "John"), new BankAccount(132423234));


            foreach (var re in dict)
            {
                KeyValuePair<Person,BankAccount> de=(KeyValuePair<Person,BankAccount>)re;
                   
                
                    Console.WriteLine(de.Key.ID +" "+ 
                        de.Key.Name+ " " + de.Value.Account_Balance);
                

                
            }





            //Person s1 = new Person() {ID=1,Name="Aij" };
            //Hashtable h1 = new Hashtable();
            //h1.Add(s1.ID,s1.Name);

                
            //foreach (var item in h1)
            //{
            //    DictionaryEntry de = (DictionaryEntry)item;
            //    Console.WriteLine(de.Key+" "+ de.Value);
            //}
        }
    }
}
