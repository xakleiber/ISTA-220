using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militarry_Inheritance
{
    class FirstSgt : HHC
    {
        protected void name(string NAME)
        {
            Console.WriteLine($"I am the First SGT");
        }
        public void Speek(string val)
        {
            Console.WriteLine("hello");
        }
    }
}
