using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Context
    {
        public Strategy ContextStrategy;
        public Context(Strategy strategy)
        {
            this.ContextStrategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return this.ContextStrategy.DoOperation(a, b);
        }
    }
}
