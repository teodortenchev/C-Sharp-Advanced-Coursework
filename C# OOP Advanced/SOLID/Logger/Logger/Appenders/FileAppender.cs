namespace Logger.Appenders
{
    using Layouts.Contracts;
    using Loggers.Enums;
    using Loggers.Contracts;
    using System.IO;

    public class FileAppender : Appender
    {
        private const string Path = "log.txt";

        private readonly ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile) : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                string content = string.Format(layout.Format, dateTime, reportLevel, message)
                                                        + System.Environment.NewLine;
                File.AppendAllText(Path, content);

                logFile.Write(content);

                MessagesAppended++;
            }
        }

        public override string Status()
        {
            string appenderType = this.GetType().Name;

            string result = $"Appender type: {appenderType}, " +
                $"Layout type: {LayoutType.GetType().Name}, " +
                $"Report level: {ReportLevel.ToString().ToUpper()}, " +
                $"Messages appended: {MessagesAppended}, " +
                $"File size: {logFile.Size}";

            return result;
        }
    }
}
