using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class DefaultWearingStrategy: IWearingStrategy
    {
        public string GetClothes()
        {
            return "coat";
        }

        public string GetAccessories()
        {
            return "nothing";
        }
    }
}
