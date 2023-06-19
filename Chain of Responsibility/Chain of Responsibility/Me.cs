using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class Me: WeirdCafeVisitor
    {
        public Me(WeirdCafeVisitor cafeVisitor) : base(cafeVisitor) { }

        public override void HandleFood(Food food)
        {
            if (!food.Ingredients.Contains("Coffee"))
            {
                Console.WriteLine($"Me: I liked {food.Name}. It went well");
            }
            base.HandleFood(food);
        }
    }
}
