using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class EnterpriseLogger: LoggingProviders, ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"EnterpriseLogger: {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"EnterpriseLogger: {message}");
        }

        public void LogVerboseInformation(string message)
        {
            Console.WriteLine($"EnterpriseLogger: {message}");
        }
    }
}
