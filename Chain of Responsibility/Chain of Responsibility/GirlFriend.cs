using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class GirlFriend: WeirdCafeVisitor
    {
        public GirlFriend(WeirdCafeVisitor cafeVisitor): base(cafeVisitor) { }

        public override void HandleFood(Food food)
        {
            if(food.Name == "Cappuccino")
            {
                Console.WriteLine($"GF: My lovely cappuccino!");
                return;
            }
            base.HandleFood(food);
        }
    }
}
