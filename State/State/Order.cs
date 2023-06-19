using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Order
    {
        private OrderState _state;
        private List<Product> _products = new List<Product>();

        public Order()
        {
            _state = new NewOrder(this);
        }

        public void SetOrderState(OrderState state)
        {
            _state = state;
        }

        public void WriteCurrentStateName()
        {
            Console.WriteLine($"Current Order's state: {_state.GetType().Name}");
        }

        public void DoShipping()
        {
            Console.WriteLine("Shipping...");
        }

        public void DoCancel()
        {
            Console.WriteLine("Cancelling order...");
        }

        public void DoAddProduct()
        {
            Console.WriteLine("Adding product...");
        }
        public void DoGrant()
        {
            Console.WriteLine("Granting...");
        }

        public void DoInvoice()
        {
            Console.WriteLine("Invoicing...");
        }

        public void DoRegister()
        {
            Console.WriteLine("Registration...");
        }

        public void AddProduct(Product product)
        {
            _state.AddProduct();
            _products.Add(product);
        }

        public void Register()
        {
            _state.Register();
        }

        public void Ship()
        {
            _state.Ship();
        }

        public void Grant()
        {
            _state.Grant();
        }

        public void Cancel()
        {
            _state.Cancel();
        }

        public void Invoice()
        {
            _state.Invoice();
        }
    }
}
