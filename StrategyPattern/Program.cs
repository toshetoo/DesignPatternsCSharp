using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context add = new Context(new OperationAdd());
            Context multiply = new Context(new OperationMultiply());

            Console.WriteLine(add.ExecuteStrategy(5, 10));
            Console.WriteLine(multiply.ExecuteStrategy(5, 10));
        }
    }
}
