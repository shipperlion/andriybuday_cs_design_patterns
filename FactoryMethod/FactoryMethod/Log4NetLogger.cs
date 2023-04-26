using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Log4NetLogger : ILogger
    {
        public const string Name = "Log4Net";
        public void LogMessage(string message)
        {
            Console.WriteLine($"Log4Net message: {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"Log4Net error: {message}");
        }

        public void LogVerboseInformation(string message)
        {
            Console.WriteLine($"Log4Net info: {message}");
        }
    }
}
