using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class GoodsPackage: Goods
    {
        public List<Goods> GoodsInside { get; set; }

        public override int Interpret(CurrentPricesContext context)
        {
            var totalSum = 0;
            foreach(var goods in GoodsInside)
            {
                totalSum += goods.Interpret(context);
            }
            return totalSum;
        }
    }
}
