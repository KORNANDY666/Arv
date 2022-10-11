using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Animal
    {
        public string name { get; set; }
        public string color { get; set; }
        public int age { get; set; }
        public string spices { get; set; }
        public string origin { get; set; }

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
