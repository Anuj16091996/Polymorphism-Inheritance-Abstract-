using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    class Owner1
    {
        public string Name { get; set; }
        public Owner1(string name,Dog dog)
        {
            this.Name = name;
            //dog.AddAlaramHandler(new HostAlaram(this.AlaramOnCheck));
            dog.Alaram += this.AlaramOnCheck;
        }

      

        public void AlaramOnCheck()
        {
            Console.WriteLine(this.Name+ "- Your Dog Has Smell Something Strange");
        }

    }
}
