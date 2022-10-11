using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Indochinese_Tiger : Tiger
    {
        int Jump;

        public Indochinese_Tiger(int Jump,string Sight, string name, string color, int age, string spices, string origin) : base(Sight, name, color, age, spices, origin)
        {
            this.Jump = Jump;
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

        public void Survive()
        { 
        
        
        }

        public override void MakeSound()
        {
            Console.WriteLine("Indonesiska Tigern {0} orkar inte låta, för att hon försöker att sova  ", name);
        }

    }
}
