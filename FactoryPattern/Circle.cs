using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Draw cicrle");
        }
    }
}
