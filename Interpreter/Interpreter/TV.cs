using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class TV: Goods
    {
        public override int Interpret(CurrentPricesContext context)
        {
            int price = context.GetPrice("TV");
            Console.WriteLine($"TV: {price}");
            return price;
        }
    }
}
