using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    interface ILogger
    {
        void LogMessage(string message);
        void LogError(string message);
        void LogVerboseInformation(string message);
    }
}
