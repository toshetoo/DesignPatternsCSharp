using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    class CocoaShake : Shake
    {

        public CocoaShake()
        {
            this.Ingredients = "cocoa and milk.";
        }
        public override void Price()
        {
            Console.WriteLine("You bought a cocoa shake for 10$");
        }
    }
}
