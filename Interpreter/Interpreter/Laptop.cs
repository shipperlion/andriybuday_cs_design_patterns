using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class Laptop: Goods
    {
        public override int Interpret(CurrentPricesContext context)
        {
            int price = context.GetPrice("Laptop");
            Console.WriteLine($"Laptop: {price}");
            return price;
        }
    }
}
