using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Ear: BodyPart
    {
        public Ear(Brain brain) : base(brain) { }

        public string GetSounds()
        {
            Console.WriteLine("Enter what you hear:");
            return Console.ReadLine();
        }
    }
}
