using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class ElectricitySystemValidator: IVisitor
    {
        public void Visit(OfficeBuilding building)
        {
            var electricityState = (building.ElectricitySystemId > 1000) ? "Good" : "Bad";
            Console.WriteLine($"Main electric shield in building {building.BuildingName} is in {electricityState} state.");
        }
        public void Visit(Floor floor)
        {
            Console.WriteLine($"Diagnosing electricity on floor {floor.FloorNumber}.");
        }
        public void Visit(Room room)
        {
            Console.WriteLine($"Diagnosing electricity in room {room.RoomNumber}.");
        }
    }
}
