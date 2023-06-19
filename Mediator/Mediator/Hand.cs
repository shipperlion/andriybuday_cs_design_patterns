using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Hand: BodyPart
    {
        public Hand(Brain brain) : base(brain) { }

        public void Embrace()
        {
            Console.WriteLine("HAND: Embracing what is in front of you...");
        }

        public void Hit()
        {
            Console.WriteLine("HAND: Just hitted offender...");
        }

        public bool DoesItHurt()
        {
            Console.WriteLine("What you feel is hurting? (Yes/No)");
            if (Console.ReadLine() == "Yes")
                return true;
            return false;
        }

        public bool IsItNice()
        {
            Console.WriteLine("What you feel is soft? (Yes/No)");
            if (Console.ReadLine() == "Yes")
                return true;
            return false;
        }
    }
}
