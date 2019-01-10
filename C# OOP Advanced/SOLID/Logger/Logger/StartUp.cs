namespace Logger
{
    using Appenders;
    using Appenders.Contracts;
    using Layouts;
    using Layouts.Contracts;
    using Loggers;
    using Loggers.Contracts;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var xmlLayout = new XmlLayout();
            var consoleAppender = new ConsoleAppender(xmlLayout);

            var file = new LogFile();
            var fileAppender = new FileAppender(xmlLayout, file);

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");


        }
    }
}
