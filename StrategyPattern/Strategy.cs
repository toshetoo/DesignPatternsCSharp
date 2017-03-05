using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface Strategy
    {
        int DoOperation(int a, int b);
    }
}
