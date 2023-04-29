using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class LoggerSingleton
    {
        private LoggerSingleton() { }
        private int _logCount = 0;
        private static LoggerSingleton _loggerSingletonInstance = null;
        public static LoggerSingleton GetInstance()
        {
            if(_loggerSingletonInstance == null)
            {
                _loggerSingletonInstance = new LoggerSingleton();
            }
            return _loggerSingletonInstance;
        }

        public void Log(String message)
        {
            Console.WriteLine($"{_logCount}: {message}");
            _logCount++;
        }
    }
}
