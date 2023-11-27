using System;
using System.Collections.Generic;
using System.Text;

namespace LogSystem
{
    public class LoggerManager
    {
        private readonly ILogger logger;

        public LoggerManager(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogMessage(string message)
        {
            
            logger.LogMessage(message);
        }
    }
}
