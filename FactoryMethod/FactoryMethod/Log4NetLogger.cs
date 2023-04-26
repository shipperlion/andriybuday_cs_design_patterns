using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Log4NetLogger : LoggingProviders, ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Log4Net: {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"Log4Net: {message}");
        }

        public void LogVerboseInformation(string message)
        {
            Console.WriteLine($"Log4Net: {message}");
        }
    }
}
