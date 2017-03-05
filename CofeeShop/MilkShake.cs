using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    class MilkShake : Shake
    {

        public MilkShake()
        {
            this.Ingredients = "milk and chocolate.";
        }
        public override void Price()
        {
            Console.WriteLine("Milk shake price: 10$");
        }
    }
}
