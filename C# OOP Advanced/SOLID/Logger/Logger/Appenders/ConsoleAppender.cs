namespace Logger.Appenders
{
    using System;
    using Contracts;
    using Layouts.Contracts;
    using Loggers.Enums;

    public class ConsoleAppender : IAppender
    {
        private readonly ILayout layout;

        public ConsoleAppender(ILayout layout)
        {
            this.layout = layout;
        }

        public ReportLevel ReportLevel { get; set; }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if(reportLevel >= this.ReportLevel)
            {
            Console.WriteLine(string.Format(layout.Format, dateTime, reportLevel, message));
            }
        }
    }
}
