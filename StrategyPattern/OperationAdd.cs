using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class OperationAdd : Strategy
    {
        public int DoOperation(int a, int b)
        {
            return a + b;
        }
    }
}
