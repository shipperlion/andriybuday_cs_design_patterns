using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class BodyPart
    {
        private readonly Brain _brain;

        public BodyPart(Brain brain)
        {
            _brain = brain;
        }

        public void Changed()
        {
            _brain.SomethingHappenedToBodyPart(this);
        }
    }
}
