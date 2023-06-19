using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Shipped: OrderState
    {
        public Shipped(Order order): base(order) { }

        public override void Invoice()
        {
            _order.DoInvoice();
            _order.SetOrderState(new Invoiced(_order));
        }
    }
}
