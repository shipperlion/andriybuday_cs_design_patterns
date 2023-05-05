using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class AmbulanceCar: DecoratorCar
    {
        public AmbulanceCar(Car decoratedCar): base(decoratedCar) { }

        public override void Go()
        {
            base.Go();
            Console.WriteLine("...beep-beep-beeeep....");
        }
    }
}
