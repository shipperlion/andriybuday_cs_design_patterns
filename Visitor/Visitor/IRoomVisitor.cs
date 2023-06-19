using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal interface IRoomVisitor
    {
        void Visit(Room room);
    }
}
