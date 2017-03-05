using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = ShapeFactory.GetShape(ShapeType.Circle);
            shape1.Draw();
            Shape shape2 = ShapeFactory.GetShape(ShapeType.Square);
            shape2.Draw();

            Console.ReadKey(true);
        }
    }
}
