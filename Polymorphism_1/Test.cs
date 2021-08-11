using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_1
{
    class Test
    {
        Animals[] an;
        public  void Started()
        {
            Animals[] any= new Animals[5];

            any[0] = new Frog(12, "Frogi", "Male");
             any[1] = new Dog(5, "Tommy", "Female");
            any[2] = new Cat(6,"Catyy-cat","Male");
            any[3] = new Kitten(67,"Virginia","Female");
            any[4] = new Tomcat(123,"Tommy-Catty","Female");


            an = any;

        }

        public void Display()
        {
            for(int i=0; i<an.Length;i++)
            {
                Console.WriteLine("Age= "+an[i].Age +"\n" +
                    "Name= "+an[i].Name +"\n" +
                    "Gender= "+an[i].Gender+"\n" +
                    "Noise- "+an[i].Noise() +"\n" +
                    "");
            }
        }
    }
}
