using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerSingleton logger = LoggerSingleton.GetInstance();
            HardProcessor processor = new HardProcessor(1);
            logger.Log("Hard work started");
            processor.ProcessTo(5);
            logger.Log("Hard work finished");
        }
    }
}
