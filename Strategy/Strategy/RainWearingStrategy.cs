using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class RainWearingStrategy: IWearingStrategy
    {
        public string GetClothes()
        {
            return "coat";
        }

        public string GetAccessories()
        {
            return "umbrella";
        }
    }
}
