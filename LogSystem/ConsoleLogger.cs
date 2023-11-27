using System;
using System.Collections.Generic;
using System.Text;

namespace LogSystem
{
    public class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Console Log: {message}");
        }
    }
}
