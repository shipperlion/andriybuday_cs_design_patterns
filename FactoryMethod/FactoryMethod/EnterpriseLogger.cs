using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class EnterpriseLogger: ILogger
    {
        public const string Name = "Enterprise";
        public void LogMessage(string message)
        {
            Console.WriteLine($"EnterpriseLogger message: {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"EnterpriseLogger error: {message}");
        }

        public void LogVerboseInformation(string message)
        {
            Console.WriteLine($"EnterpriseLogger info: {message}");
        }
    }
}
