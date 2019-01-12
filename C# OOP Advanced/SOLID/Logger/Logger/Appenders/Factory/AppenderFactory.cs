namespace Logger.Appenders.Factory
{
    using Contracts;
    using Layouts.Contracts;
    using Loggers;
    using System;

    public class AppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            switch (type)
            {
                case "ConsoleAppender":
                    return new ConsoleAppender(layout);
                    
                case "FileAppender":
                    return new FileAppender(layout, new LogFile());
                   

                default:
                    throw new ArgumentException("Invalid appender type.");
                    
            }
        }
    }
}
