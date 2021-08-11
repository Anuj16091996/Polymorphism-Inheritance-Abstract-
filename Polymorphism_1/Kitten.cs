using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_1
{
    class Kitten:Animals
    {
        public Kitten(int age, string name, string gender)
        {
            Age = age;
            Name = name;
            Gender = gender;

        }

        public override string Noise()
        {
            return "Kitten Make Mow Mow Noise";
        }
    }
}
