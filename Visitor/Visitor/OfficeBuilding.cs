using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class OfficeBuilding: IElement
    {
        private readonly List<Floor> _floors = new List<Floor>();
        public int ElectricitySystemId { get; private set; }
        public string BuildingName { get; private set; }
        public int BuildingAge { get; private set; }
        public IEnumerable<Floor> Floors { get { return _floors; } }

        public OfficeBuilding(string buildingName, int buildingAge, int electricitySystemId)
        {
            BuildingName = buildingName;
            BuildingAge = buildingAge;
            ElectricitySystemId = electricitySystemId;
        }

        public void AddFloor(Floor floor)
        {
            _floors.Add(floor);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var floor in Floors)
            {
                floor.Accept(visitor);
            }
        }
    }
}
