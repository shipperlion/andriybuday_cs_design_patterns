using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            var providerType = GetTypeOfLoggingProviderFromConfig();
            ILogger logger = LoggerProviderFactory.GetLoggingProvider(providerType);
            logger.LogMessage("Factory Method Design Pattern");
        }

        private static string GetTypeOfLoggingProviderFromConfig()
        {
            return Log4NetLogger.Name;
        }
    }
}
