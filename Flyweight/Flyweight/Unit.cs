using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal abstract class Unit
    {
        public string Name { get; protected set; }

        public int Health { get; protected set; }

        public Image Picture { get; protected set; }


    }
}
