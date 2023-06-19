using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Leg : BodyPart
    {
        public Leg(Brain brain) : base(brain) { }

        public void StepForward()
        {
            Console.WriteLine("LEG: Stepping forward...");
        }

        public void StepBack()
        {
            Console.WriteLine("LEG: Stepping back...");
        }

        public void Kick()
        {
            Console.WriteLine("LEG: Just kicked offender in front of you...");
        }

        public bool IsItSlippery()
        {
            Console.WriteLine("Path further is slippery? (Yes/No)");
            if (Console.ReadLine() == "Yes")
                return true;
            return false;
        }
    }
}
