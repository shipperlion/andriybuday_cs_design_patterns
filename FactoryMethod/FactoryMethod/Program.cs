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

        private static LoggingProviders GetTypeOfLoggingProviderFromConfig()
        {
            return LoggingProviders.Log4Net;
        }
    }
}
