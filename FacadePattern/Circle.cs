using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Circle: draw()");
        }
    }
}
