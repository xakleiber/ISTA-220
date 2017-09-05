using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Chicken ch = new Chicken();
            ch.whatAmI("chicken");
            ch.speak("Bok Bok");

            Cow cow = new Cow();
            cow.whatAmI("cow");
            cow.speak("moo");

            Goat goat = new Goat();
            goat.whatAmI("goat");
            goat.speak("Baaaaah");

            Pig pig = new Pig();
            pig.whatAmI("pig");
            pig.speak("oink");
        }
    }
}
