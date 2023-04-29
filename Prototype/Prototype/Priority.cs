using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Priority
    {
        private int Value { get; set; }
        //public static int High() { return 5; }

        public void SetPriorityValue(int priority)
        {
            this.Value = priority;
        }

        public bool IsHigh()
        {
            if (Value == 5)
                return true;
            return false;
        }

        public Priority Clone()
        {
            var copy = new Priority();
            copy.Value = Value;
            return copy;
        }
    }
}
