namespace Logger.Core
{
    using System;

    using Contracts;
    using Appenders.Contracts;
    using System.Collections.Generic;
    using Appenders.Factory;
    using Logger.Loggers.Enums;
    using Layouts.Factory;
    using Logger.Layouts.Contracts;

    class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private AppenderFactory appenderFactory;
        private LayoutFactory layoutFactory;


        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
        }

        public void AddAppender(string[] args)
        {
            string appenderType = args[0];
            string layoutType = args[1];

            ReportLevel reportLevel = ReportLevel.INFO;

            if (args.Length == 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2], true);
            }

            ILayout layout = layoutFactory.CreateLayout(layoutType);
            IAppender appender = appenderFactory.CreateAppender(appenderType, layout);
            appender.ReportLevel = reportLevel;

            appenders.Add(appender);

        }

        public void AddMessage(string[] args)
        {
            ReportLevel reportLevel = Enum.Parse<ReportLevel>(args[0], true);
            string dateTime = args[1];
            string message = args[2];

            foreach (var appender in appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public void PrintAppenders()
        {
            Console.WriteLine("Logger info");

            foreach (var appender in appenders)
            {
                Console.WriteLine(appender.Status());
            }
        }
    }
}
