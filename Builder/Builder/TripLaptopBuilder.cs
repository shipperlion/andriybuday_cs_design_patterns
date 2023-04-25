using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class TripLaptopBuilder: LaptopBuilder
    {
        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1200X800";

        }

        public override void SetProcessor()
        {
            Laptop.Processor = "trip processor";
        }

        public override void SetMemory()
        {
            Laptop.Memory = "3072 Mb";
        }

        public override void SetHDD()
        {
            Laptop.HDD = "128 Gb";
        }

        public override void SetBattery()
        {
            Laptop.Battery = "6 lbs";
        }
    }
}
