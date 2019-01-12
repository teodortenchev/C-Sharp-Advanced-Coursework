namespace Logger.Appenders
{
    using Contracts;
    using Layouts.Contracts;
    using Loggers.Enums;

    public abstract class Appender : IAppender
    {
        protected readonly ILayout layout;

        public string LayoutType => layout.GetType().Name;
        public int MessagesAppended { get; protected set; }

        public ReportLevel ReportLevel { get; set; }


        protected Appender(ILayout layout)
        {
            this.layout = layout;
            MessagesAppended = 0;
        }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);


        public abstract string Status();
    
    }
}
