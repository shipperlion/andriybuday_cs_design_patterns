using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class LoggerProviderFactory
    {
        public static ILogger GetLoggingProvider(string logProvider)
        {
            switch (logProvider)
            {
                case EnterpriseLogger.Name:
                    return new EnterpriseLogger();
                case Log4NetLogger.Name:
                    return new Log4NetLogger();
                default:
                    return new EnterpriseLogger();
            }
        }
    }
}
