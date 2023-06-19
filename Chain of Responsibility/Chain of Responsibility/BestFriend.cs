using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class BestFriend: WeirdCafeVisitor
    {
        public List<Food> CoffeeContainingFood { get; private set; }

        public BestFriend(WeirdCafeVisitor cafeVisitor): base(cafeVisitor)
        {
            CoffeeContainingFood = new List<Food>();
        }

        public override void HandleFood(Food food)
        {
            if (food.Ingredients.Contains("Meat"))
            {
                Console.WriteLine($"BF: I've just ate {food.Name}. It was tasty");
                return;
            }
            if (food.Ingredients.Contains("Coffee") && CoffeeContainingFood.Count < 1)
            {
                CoffeeContainingFood.Add(food);
                Console.WriteLine($"BF: I need coffee. {food.Name} looks fine");
                return;
            }
            base.HandleFood(food);
        }
    }
}
