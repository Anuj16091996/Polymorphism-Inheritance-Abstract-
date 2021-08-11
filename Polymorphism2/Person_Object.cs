using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    class Person_Object
    {

        public void started()
        {

       
        Person p1 = new Person();

        Microwave m1 = new Microwave();
        Stove s1 = new Stove();


            Console.WriteLine(   p1.UseKitchenAppliance(m1));
            Console.WriteLine( p1.UseKitchenAppliance(s1));


        }

    }
}
