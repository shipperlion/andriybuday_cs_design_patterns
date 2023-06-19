using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class PlumbingSystemValidator: IVisitor
    {
        public void Visit(OfficeBuilding building)
        {
            var plumbingState = (building.BuildingAge < 30) ? "Good" : "Bad";
            var buildingState = (plumbingState == "Good") ? "New" : "Old";
            Console.WriteLine($"Plumbing state of building {building.BuildingName} probably is in {plumbingState} condition since builing is {buildingState}. ");
        }
        public void Visit(Floor floor)
        {
            Console.WriteLine($"Diagnosing plumbing on floor {floor.FloorNumber}.");
        }

        public void Visit(Room room) { }
    }
}
