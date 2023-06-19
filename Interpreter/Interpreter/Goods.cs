using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal abstract class Goods
    {
        public abstract int Interpret(CurrentPricesContext context);
    }
}
