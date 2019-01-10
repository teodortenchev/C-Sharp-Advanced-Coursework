namespace Logger.Loggers
{
    using Appenders.Contracts;
    using Contracts;
    using Enums;

    public class Logger : ILogger
    {
        private readonly IAppender consoleAppender;
        private readonly IAppender fileAppender;

        public Logger(IAppender consoleApennder)
        {
            this.consoleAppender = consoleApennder;
        }

        public Logger(IAppender consoleAppender, IAppender fileAppender) : this(consoleAppender)
        {
            this.fileAppender = fileAppender;
        }

        public void Critical(string dateTime, string errorMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.Critical, errorMessage);
        }

        public void Error(string dateTime, string errorMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.Error, errorMessage);

        }

        public void Fatal(string dateTime, string errorMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.Fatal, errorMessage);
        }

        public void Info(string dateTime, string errorMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.Info, errorMessage);
        }

        public void Warning(string dateTime, string errorMessage)
        {
            this.AppendMessage(dateTime, ReportLevel.Warning, errorMessage);
        }

        private void AppendMessage(string dateTime, ReportLevel reportLevel, string errorMessage)
        {
            consoleAppender?.Append(dateTime, reportLevel, errorMessage);
            fileAppender?.Append(dateTime, reportLevel, errorMessage);
        }
    }
}
