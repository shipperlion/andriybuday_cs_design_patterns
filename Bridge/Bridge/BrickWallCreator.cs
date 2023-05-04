using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class BrickWallCreator: IWallCreator
    {
        public void BuildWall()
        {
            Console.WriteLine("Brick wall");
        }

        public void BuildWallWithDoor()
        {
            Console.WriteLine("Brick wall with door");
        }

        public void BuildWallWithWindow()
        {
            Console.WriteLine("Brick wall with window");
        }
    }
}
