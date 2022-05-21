using SimplifiedSoftwareComplexity.Fundamentals;
using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;

namespace SimplifiedSoftwareComplexity.Interfaces
{
    public interface ILogRecord : ILogArchive, ISessionArchive, IDurationArchive, IRecord, IArchive, ILog
    {
        // TODO: Need to grab values from ILogLogicRecord
        string? NamespaceName { get; set; }
        string? ClassName { get; set; }
        string? MethodName { get; set; }
        public object? BeginningParameters { get; set; }
        public object? EndingParameters { get; set; }
        bool IsCurrentMessageString { get; set; }
        public StringOrObject? CurrentMessage { get; set; }
        List<StringOrObject>? PreviousMessages { get; set; }
        public int EndIncrement { get; set; }
        public bool OnMethodEndCalled { get; set; }
        public bool IsMethodEnd { get; set; }
        public void SetCurrentMessage(string newMessage);
        public void SetCurrentMessage(object newMessage);
        public bool ExistsCurrentMessage();
        public void AddToPreviousMessages(StringOrObject lastCurrentMessage);
    }
}
