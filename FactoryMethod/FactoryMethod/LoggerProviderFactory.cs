using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class LoggerProviderFactory
    {
        public static ILogger GetLoggingProvider(LoggingProviders logProviders)
        {
            switch (logProviders)
            {
                // nameof?
                case LoggingProviders.Enterprise:
                    return new EnterpriseLogger();
                case LoggingProviders.Log4Net:
                    return new Log4NetLogger();
                default:
                    return new EnterpriseLogger();
            }
        }
    }
}
