using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Crocodile : Animal
    {
        string Water { get; set; } = "No Water";

        // constructor that takes in the inherited properties and its own property

        public Crocodile(string Water, string name,string color,int age, string spices, string origin) : base(name,color,age,spices,origin)
        {
            this.Water = Water;
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

        public void Sunbathing()
        { 
        
        }

        //We override the method to get different output from different animals.
        public override void MakeSound()
        {
            Console.WriteLine("Krokodilen {0} gör nånting som kan liknas ljud! ", name);
        }

    }
}
