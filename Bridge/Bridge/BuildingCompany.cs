using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class BuildingCompany: IBuildingCompany
    {
        public IWallCreator WallCreator { get; set; }
        public void BuildFoundation()
        {
            Console.WriteLine($"Foundation is built. {Environment.NewLine}");
        }

        public void BuildRoom()
        {
            WallCreator.BuildWallWithDoor();
            WallCreator.BuildWall();
            WallCreator.BuildWallWithWindow();
            WallCreator.BuildWall();
            Console.WriteLine($"Room finished. {Environment.NewLine}");
        }

        public void BuildRoof()
        {
            Console.WriteLine($"Roof is done. {Environment.NewLine}");
        }
    }
}
