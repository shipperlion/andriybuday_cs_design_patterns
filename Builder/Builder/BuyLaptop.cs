using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuyLaptop
    {
        private LaptopBuilder _laptopBuilder;
        public void SetLaptopBuilder(LaptopBuilder lBuilder)
        {
            _laptopBuilder = lBuilder;
        }

        public Laptop GetLaptop() { return _laptopBuilder.GetLaptop(); }

        public void ConstructLaptop()
        {
            _laptopBuilder.CreateNewLaptop();
            _laptopBuilder.SetMonitorResolution();
            _laptopBuilder.SetProcessor();
            _laptopBuilder.SetMemory();
            _laptopBuilder.SetHDD();
            _laptopBuilder.SetBattery();
        }
    }
}
