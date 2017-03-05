using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ShapeFactory
    {
        public static Shape GetShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Square:
                    return new Square();
                default: return null;
            }
        }
    }

    public enum ShapeType
    {
        Circle,
        Square
    }
}
