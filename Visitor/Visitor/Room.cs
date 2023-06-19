using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Room
    {
        public int RoomNumber { get; private set; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
