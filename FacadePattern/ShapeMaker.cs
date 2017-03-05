using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class ShapeMaker
    {
        private Circle circle;
        private Square square;

        public ShapeMaker()
        {
            circle = new Circle();
            square = new Square();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void DrawSquare()
        {
            square.Draw();
        }
    }
}
