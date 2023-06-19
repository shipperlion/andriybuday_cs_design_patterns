using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Canceled: OrderState
    {
        public Canceled(Order order) : base(order) { }
    }
}
