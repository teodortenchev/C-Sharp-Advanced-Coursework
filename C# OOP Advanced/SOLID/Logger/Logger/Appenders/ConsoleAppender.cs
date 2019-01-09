namespace Logger.Appenders
{
    using Contracts;
    using Layouts.Contracts;
    using System;

    public class ConsoleAppender : IAppender
    {
        private readonly ILayout layout;

        public ConsoleAppender(ILayout layout)
        {
            this.layout = layout;
        }

        public void Append(string dateTime, string errorLevel, string message)
        {
            Console.WriteLine(string.Format(layout.Format, dateTime, errorLevel, message));
        }
    
    }
}
