namespace Logger.Appenders
{
    using Contracts;
    using Layouts.Contracts;
    using Loggers.Enums;
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

        public ReportLevel ReportLevel { get; set; }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            string content = string.Format(layout.Format, dateTime, reportLevel, message)
                                                        + System.Environment.NewLine;

            File.AppendAllText(Path, content);

          
        }
    }
}
