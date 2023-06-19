using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SunshineWearingStrategy: IWearingStrategy
    {
        public string GetClothes()
        {
            return "T-shirt";
        }

        public string GetAccessories()
        {
            return "sunglasses";
        }
    }
}
