using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Car
    {
        protected string BrandName { get; set; }

        public virtual void Go() { Console.WriteLine($"I'm {BrandName} and I'm on my way"); }
    }
}
