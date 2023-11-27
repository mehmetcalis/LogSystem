using System;
using System.Collections.Generic;
using System.Text;

namespace LogSystem
{
    public class FileLogger : ILogger
    {
        public void LogMessage(string message)
        {            
            Console.WriteLine($"File Log: {message}");
        }
    }
}
