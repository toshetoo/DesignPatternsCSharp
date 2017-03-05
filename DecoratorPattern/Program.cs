using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            Shape redCircle = new RedShapeDecorator(new Circle());
            Shape redRectangle = new RedShapeDecorator(new Square());
            Console.WriteLine("Circle with normal border");
            circle.Draw();
            Console.WriteLine("\nCircle of red border");
            redCircle.Draw();
            Console.WriteLine("\nRectangle of red border");
            redRectangle.Draw();            Console.ReadKey(true);
        }
    }
}
