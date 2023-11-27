using System;

namespace LogSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            ILogger fileLogger = new FileLogger();
            ILogger memoryLogger = new MemoryLogger();

          
            
            LoggerManager consoleLoggerManager = new LoggerManager(consoleLogger);
            LoggerManager fileLoggerManager = new LoggerManager(fileLogger);
            LoggerManager memoryLoggerManager = new LoggerManager(memoryLogger);

            Console.WriteLine("Insert your logging message");
            string message = Console.ReadLine();

            
            consoleLoggerManager.LogMessage(message);
            fileLoggerManager.LogMessage(message);
            memoryLoggerManager.LogMessage(message);



            Console.ReadLine();
        }
    }
}
