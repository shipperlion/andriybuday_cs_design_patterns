using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class CurrentPricesContext
    {
        // TODO: ???
        public CurrentPricesContext()
        {
            Prices = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Prices { get; private set; }
        public void SetPrice(string name, int price)
        {
            Prices.Add(name, price);
        }

        public int GetPrice(string name)
        {
            if(Prices.ContainsKey(name))
                return Prices[name];
            return -1;
        }
    }
}
