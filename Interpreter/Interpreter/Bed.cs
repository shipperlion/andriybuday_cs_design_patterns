using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class Bed: Goods
    {
        public override int Interpret(CurrentPricesContext context)
        {
            int price = context.GetPrice("Bed");
            Console.WriteLine($"Bed: {price}");
            return price;
        }
    }
}
