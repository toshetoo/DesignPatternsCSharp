using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportChainOfResponsibilities
{
    abstract class Approver
    {
        protected Approver Successor { get; set; }
        public void SetSuccessor(Approver successor)
        {
            this.Successor = successor;
        }

        public abstract void ProcessRequest(Flight flight);

    }
}
