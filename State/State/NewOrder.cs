using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class NewOrder: OrderState
    {
        public NewOrder(Order order) : base(order) { }

        public override void AddProduct()
        {
            _order.DoAddProduct();
        }

        public override void Register()
        {
            _order.DoRegister();
            _order.SetOrderState(new Registered(_order));
        }

        public override void Cancel()
        {
            _order.DoCancel();
            _order.SetOrderState(new Canceled(_order));
        }
    }
}
