using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Granted: OrderState
    {
        public Granted(Order order) : base(order) { }
        public override void AddProduct()
        {
            _order.DoAddProduct();
        }
        public override void Ship()
        {
            _order.DoShipping();
            _order.SetOrderState(new Shipped(_order));
        }
        public override void Cancel()
        {
            _order.DoCancel();
            _order.SetOrderState(new Canceled(_order));
        }

    }
}
