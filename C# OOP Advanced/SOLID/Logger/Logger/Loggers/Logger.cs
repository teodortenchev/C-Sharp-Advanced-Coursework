namespace Logger.Loggers
{
    using Contracts;
    using Appenders.Contracts;

    public class Logger : ILogger
    {
        private readonly IAppender consoleAppender;
        private readonly IAppender fileAppender;

        public Logger(IAppender consoleAppender, IAppender fileAppender)
        {
            this.consoleAppender = consoleAppender;
            this.fileAppender = fileAppender;
        }

        public void Error(string dateTime, string errorMessage)
        {
            consoleAppender.Append(dateTime, "Error", errorMessage);
            fileAppender.Append(dateTime, "Error", errorMessage);
        }

        public void Info(string dateTime, string errorMessage)
        {
            consoleAppender.Append(dateTime, "Info", errorMessage);
            fileAppender.Append(dateTime, "Info", errorMessage);
        }
    }
}
