
namespace Logger.Appenders.Contracts
{
    using Loggers.Enums;

    public interface IAppender
    {
        string LayoutType { get; }
        int MessagesAppended { get; }
        ReportLevel ReportLevel { get; set; }
        void Append(string dateTime, ReportLevel reportLevel, string message);
        string Status();
    }
}
