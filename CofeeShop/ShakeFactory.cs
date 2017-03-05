using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    class ShakeFactory
    {
        public static Shake GetShake(ShakeType type)
        {
            switch (type)
            {
                case ShakeType.CocoaShake:
                    return new CocoaShake();
                case ShakeType.MilkShake:
                    return new MilkShake();
                default:
                    return null;
            }
        }
    }

    public enum ShakeType
    {
        CocoaShake,
        MilkShake
    }
}
