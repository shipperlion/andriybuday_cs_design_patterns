using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Face: BodyPart
    {
        public Face(Brain brain) : base(brain) { }

        public void Smile()
        {
            Console.WriteLine("FACE: Smiling...");
        }

        public void Frown()
        {
            Console.WriteLine("FACE: Frowning...");
        }
    }
}
