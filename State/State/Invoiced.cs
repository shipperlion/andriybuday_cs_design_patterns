using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Invoiced: OrderState
    {
        public Invoiced(Order order) : base(order) { }
    }
}
