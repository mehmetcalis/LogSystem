using System;
using System.Collections.Generic;
using System.Text;

namespace LogSystem
{
    public class MemoryLogger : ILogger
    {
        private List<string> logMessages = new List<string>();

        public void LogMessage(string message)
        {
            logMessages.Add($"Memory Log: {message}");
            Console.WriteLine($"Memory Log: {message}");
        }

    }
}
