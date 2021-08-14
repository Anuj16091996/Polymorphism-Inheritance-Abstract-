using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{   
    class Owner2
    {
        public string Name { get; set; }

        public Owner2( string name, Dog dog )
        {
            this.Name = name;
            //dog.AddAlaramHandler(this.AlaramOnCheck);
            dog.Alaram += this.AlaramOnCheck;
        }

        

        public void AlaramOnCheck()
        {
            Console.WriteLine(this.Name + "- Your Dog Has Smell Something Strange");
        }
    }
}
