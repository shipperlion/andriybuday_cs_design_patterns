using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class OrderState
    {
        protected Order _order;

        public OrderState(Order order)
        {
            _order = order;
        }

        public virtual void AddProduct()
        {
            OperationIsNotAllowed("AddProduct");
        }

        public virtual void Register()
        {
            OperationIsNotAllowed("Register");
        }

        public virtual void Ship()
        {
            OperationIsNotAllowed("Ship");
        }

        public virtual void Grant()
        {
            OperationIsNotAllowed("Grant");
        }

        public virtual void Invoice()
        {
            OperationIsNotAllowed("Invoice");
        }

        public virtual void Cancel()
        {
            OperationIsNotAllowed("Cancel");
        }

        private void OperationIsNotAllowed(string operationName)
        {
            Console.WriteLine($"Operation {operationName} is not allowed for Order's {this.GetType().Name} state");
        }
    }
}
