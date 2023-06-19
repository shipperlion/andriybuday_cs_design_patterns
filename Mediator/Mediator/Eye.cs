using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Eye: BodyPart
    {
        public Eye(Brain brain) : base(brain) { }

        public string TakeALook()
        {
            Console.WriteLine("Enter what you see:");
            return Console.ReadLine();
        }
    }
}
