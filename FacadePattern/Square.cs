using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Square: draw()");
        }
    }
}
