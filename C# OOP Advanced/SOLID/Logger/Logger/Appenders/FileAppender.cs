namespace Logger.Appenders
{
    using Contracts;
    using Layouts.Contracts;
    using Loggers.Contracts;
    using System.IO;

    public class FileAppender : IAppender
    {
        private const string Path = "log.txt";

        private readonly ILayout layout;
        private readonly ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
        {
            this.layout = layout;
            this.logFile = logFile;
        }

        public void Append(string dateTime, string errorLevel, string message)
        {
            string content = string.Format(layout.Format, dateTime, errorLevel, message)
                                                        + System.Environment.NewLine;

            File.AppendAllText(Path, content);
        }
    }
}
