using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.arr.Add(new Student("Anuj",24,1234));
            Person.arr.Add(new Employee("Parsa",24,1200));
            Person.arr.Add(new Student("Luis",32,234));
            Person.arr.Add(new Employee("Rohit", 26, 1900));
            Person.arr.Add(new Student("John", 36, 12234));


            foreach (var r in Person.arr)
            {
                Console.WriteLine(  r.ToString());
            }
        }
    }
}
