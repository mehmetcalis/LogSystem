using LogSystem;
using NUnit.Framework;

namespace LogSystemTest
{
    [TestFixture]
    public class LoggerTests
    {
        [Test]
        public void ConsoleLogger_LogMessage_ShouldWriteToConsole()
        {        
            ILogger consoleLogger = new ConsoleLogger();
            LoggerManager loggerManager = new LoggerManager(consoleLogger);

            loggerManager.LogMessage("Test message");
        }

        [Test]
        public void FileLogger_LogMessage_ShouldWriteToFile()
        {            
            ILogger fileLogger = new FileLogger();
            LoggerManager loggerManager = new LoggerManager(fileLogger);
           
            loggerManager.LogMessage("Test message");

        }

        [Test]
        public void MemoryLogger_LogMessage_ShouldAddToMemory()
        {     
            ILogger memoryLogger = new MemoryLogger();
            LoggerManager loggerManager = new LoggerManager(memoryLogger);
        
            loggerManager.LogMessage("Test message");

        }
    }
}