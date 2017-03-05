using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Draw: rectangle");
        }
    }
}
