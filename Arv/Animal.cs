using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Animal
    {
        // initialize variables and methods that the other animal species inherit from.
        //The methods are virtual, so that the other classes can override the methods.
        // And the properties have a default value.
        public string name { get; set; } = "No Name";
        public string color { get; set; } = "No Colour";
        public int age { get; set; } = 0;
        public string spices { get; set; } = "No Spices";
        public string origin { get; set; } = "No Origin";

        public Animal(string name, string color, int age, string spices, string origin)
        {
            this.name = name;
            this.color = color;
            this.age = age;
            this.spices = spices;
            this.origin = origin;
        }

        public virtual void Eat()
        {

        }

        public virtual void Play()
        {

        }

        public virtual void Sleep()
        {

        }

        public virtual void MakeSound()
        {

        }

     }
       





    
}
