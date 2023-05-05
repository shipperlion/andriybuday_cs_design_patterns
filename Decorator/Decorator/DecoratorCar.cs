using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DecoratorCar: Car
    {
        protected Car DecoratedCar { get; set; }

        public DecoratorCar(Car decoratedCar) { DecoratedCar = decoratedCar; }

        public override void Go()
        {
            DecoratedCar.Go();
        }
    }
}
