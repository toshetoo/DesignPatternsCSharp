using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    abstract class Shake
    {
        public string Ingredients { get; set; }

        public virtual void Serve()
        {
            Console.WriteLine("You received a shake with " + this.Ingredients);
        }
        public abstract void Price();
    }
}
