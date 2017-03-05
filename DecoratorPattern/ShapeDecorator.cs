using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class ShapeDecorator: Shape
    {
        protected Shape decoratedShape;

        public ShapeDecorator(Shape s)
        {
            this.decoratedShape = s;
        }

        public virtual void Draw()
        {
            this.decoratedShape.Draw();
        }
    }
}
