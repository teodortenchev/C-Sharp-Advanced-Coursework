namespace Logger.Loggers
{
    using Contracts;
    using Appenders.Contracts;

    public class Logger : ILogger
    {
        private readonly IAppender appender;

        public Logger(IAppender appender)
        {
            this.appender = appender;
        }

        public void Error(string dateTime, string errorMessage)
        {
            appender.Append(dateTime, "Error", errorMessage);
        }

        public void Info(string dateTime, string errorMessage)
        {
            appender.Append(dateTime, "Info", errorMessage);
        }
    }
}
