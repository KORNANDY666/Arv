using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arv
{
    internal class Tiger : Animal
    { 

        string Sight { get; set; } = "No Sight";


        
        // constructor that takes in the inherited properties and its own property

        public Tiger(string Sight,string name, string color, int age, string spices, string origin) : base(name,color,age,spices,origin)
        {
            this.Sight = Sight;
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

        public virtual void Hunts()
        { 
        
        }

        //We override the method to get different output from different animals.
        public override void MakeSound()
        {
            Console.WriteLine("Tigern {0} gör ett WOHOO ",name);
        }




    }
}
