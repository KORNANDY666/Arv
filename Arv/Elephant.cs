using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arv
{
    internal class Elephant : Animal
    {

        string Tusks { get; set; }

        // constructor that takes in the inherited properties and its own property

        public Elephant(string Tusks,string name, string color, int age, string spices, string origin) : base(name, color, age, spices, origin)
        {
            this.Tusks = Tusks;
            
        }

        public override void Eat()
        {

        }

        public override void Play()
        {

        }

        public override void Sleep()
        {

        }

        public void Bathing()
        {
            
        }


        //We override the method to get different output from different animals.
        public override void MakeSound()
        {
            Console.WriteLine("Elefanten {0} gör ett högt ljud med sin snabel  ",name );
        }
       

    }
}
