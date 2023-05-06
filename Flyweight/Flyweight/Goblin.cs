using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Goblin: Unit
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 8;
            Picture = UnitImagesFactory.CreateGoblinImage();
        }
    }
}
