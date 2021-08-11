using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_1
{
    class Cat:Animals
    {
        public Cat(int age, string name, string gender)
        {
            Age = age;
            Name = name;
            Gender = gender;

        }
        public override string Noise()
        {
            return "Cat Make Meow Meow Noise";
        }
    }
}
