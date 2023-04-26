using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class LoggingProviders
    {
        public static string Enterprise { get; }
        public static string Log4Net { get; }
    }
}
