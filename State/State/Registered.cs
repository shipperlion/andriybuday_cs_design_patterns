using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Registered: OrderState
    {
        public Registered(Order order) : base(order) { }

        public override void AddProduct()
        {
            _order.DoAddProduct();
            _order.SetOrderState(new NewOrder(_order));
        }

        public override void Grant()
        {
            _order.DoGrant();
            _order.SetOrderState(new Granted(_order));
        }

        public override void Cancel()
        {
            _order.DoCancel();
            _order.SetOrderState(new Canceled(_order));
        }
    }
}
