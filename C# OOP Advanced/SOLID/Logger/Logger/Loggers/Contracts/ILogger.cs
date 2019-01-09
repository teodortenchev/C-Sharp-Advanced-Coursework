namespace Logger.Loggers.Contracts
{
    using System;

    public interface ILogger
    {
        void Error(string dateTime, string errorMessage);
        void Info(string dateTime, string errorMessage);
    }
}
