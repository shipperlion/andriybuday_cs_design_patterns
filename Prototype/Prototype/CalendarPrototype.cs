using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class CalendarPrototype: ICloneable
    {
        public object Clone()
        {
            var copyOfPrototype = (CalendarPrototype)this.MemberwiseClone();
            return copyOfPrototype;
        }
    }
}
