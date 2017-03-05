using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shake milkShake = ShakeFactory.GetShake(ShakeType.MilkShake);
            Shake cocoaShake = ShakeFactory.GetShake(ShakeType.CocoaShake);
            milkShake.Serve();
            milkShake.Price();

            Console.WriteLine("-----");

            cocoaShake.Serve();
            cocoaShake.Price();

            Console.ReadKey(true);
        }
    }
}
