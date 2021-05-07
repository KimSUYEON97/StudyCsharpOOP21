using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChainTestApp
{
    delegate void ThereIsAFire(string location);
    class FireStation
    {
        public void Call119 (string location) { Console.WriteLine($"119? there's fire here! location is {location}"); }

        public void ShotOut(string location) { Console.WriteLine($"Go back! {location} is on Fire!"); }
        
        public void Escape(string location) { Console.WriteLine($"Get out from {location}!"); }
    }
}
