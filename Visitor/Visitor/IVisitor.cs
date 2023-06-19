﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal interface IVisitor
    {
        void Visit(OfficeBuilding building);
        void Visit(Floor floor);
        void Visit(Room room);
    }
}
