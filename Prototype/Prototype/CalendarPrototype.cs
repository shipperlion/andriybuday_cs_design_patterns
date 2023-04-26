using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class CalendarPrototype
    {
        public virtual CalendarPrototype Clone()
        {
            var copyOfPrototype = (CalendarPrototype)this.MemberwiseClone();
            return copyOfPrototype;
        }
    }
}
