using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape s) : base(s)
        {
        }

        public override void Draw()
        {
            this.decoratedShape.Draw();
            DrawRedBorder();
        }

        private void DrawRedBorder()
        {
            Console.WriteLine("Added red border");
        }
    }
}
