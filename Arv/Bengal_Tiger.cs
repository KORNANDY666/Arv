using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Bengal_Tiger : Tiger
    {
        bool Free;

        // constructor that takes in the inherited properties and its own property
        public Bengal_Tiger(bool Free,string sight, string name, string color, int age, string spices, string origin) : base(sight,name, color, age, spices, origin)
        {
            this.Free = Free;
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

        public override void Hunts()
        {

        }

        public void Family()
        { 
        
        
        }

        //We override the method to get different output from different animals.
        public override void MakeSound()
        {
            Console.WriteLine("Bengaliska Tigern {0} låter och försöker försvara sitt revir ",name);
        }
    }
}
