using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class ConcreteSlabWallCreator: IWallCreator
    {
        public void BuildWall()
        {
            Console.WriteLine("Concrete slab wall");
        }

        public void BuildWallWithDoor()
        {
            Console.WriteLine("Concrete slab wall with door");
        }

        public void BuildWallWithWindow()
        {
            Console.WriteLine("Concrete slab wall with window");
        }
    }
}
