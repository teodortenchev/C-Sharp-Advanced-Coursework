
namespace Logger.Appenders.Contracts
{
    using Loggers.Enums;

    public interface IAppender
    {
        ReportLevel reportLevel { get; set; }
        void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}
