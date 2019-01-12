namespace Logger.Appenders
{
    using System;
    using Layouts.Contracts;
    using Loggers.Enums;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }
        
        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                Console.WriteLine(string.Format(layout.Format, dateTime, reportLevel, message));
                MessagesAppended++;
            }
        }

        public override string Status()
        {
            string appenderType = this.GetType().Name;

            string result = $"Appender type: {appenderType}, " +
                $"Layout type: {LayoutType.GetType().Name}, " +
                $"Report level: {ReportLevel.ToString().ToUpper()}, " +
                $"Messages appended: {MessagesAppended}";

            return result;
        }
    }
}
