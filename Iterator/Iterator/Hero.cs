using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Hero: Soldier
    {
        private readonly int HeroHealthPoints = 500;
        protected override int MaxHealthPoints { get { return HeroHealthPoints; } }
        public Hero(string name): base(name) { }
    }
}
