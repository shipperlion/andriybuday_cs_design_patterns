using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Myself
    {
        private IWearingStrategy _wearingStrategy = new DefaultWearingStrategy();

        public void ChangeStrategy(IWearingStrategy wearingStrategy)
        {
            _wearingStrategy = wearingStrategy;
        }

        public void GoOutside()
        {
            var clothes = _wearingStrategy.GetClothes();
            var accessories = _wearingStrategy.GetAccessories();
            Console.WriteLine($"Today I wore {clothes} and took {accessories}");
        }
    }
}
