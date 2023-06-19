using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal abstract class WeirdCafeVisitor
    {
        public WeirdCafeVisitor CafeVisitor { get; private set; }

        protected WeirdCafeVisitor(WeirdCafeVisitor cafeVisitor)
        {
            CafeVisitor = cafeVisitor;
        }

        public virtual void HandleFood(Food food)
        {
            CafeVisitor?.HandleFood(food);
        }
    }
}
