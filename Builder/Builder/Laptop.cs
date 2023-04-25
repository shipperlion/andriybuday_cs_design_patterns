using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Laptop
    {
        public string MonitorResolution { get; set; }
        public string Processor { get; set; }
        public string Memory { get; set; }
        public string HDD { get; set; }
        public string Battery { get; set; }

        public override string ToString()
        {
            return $"Resolution: {MonitorResolution}\nProcessor: {Processor}\nMemory: {Memory}\nHDD: {HDD}\nBattery: {Battery}";
        }
    }
}
