using SimplifiedSoftwareComplexity.Interfaces;

namespace SimplifiedSoftwareComplexity.Classes
{
    public class LogArchive : ILogArchive
    {
        public List<string> AllMessages { get; set; }
        public string NamespaceName { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public object BeginningParameters { get; set; }
        public object EndingParameters { get; set; }
        public int EndIncrement { get; set; }
        public bool OnMethodEndCalled { get; set; }
        public bool IsMethodEnd { get; set; }
        public string SessionIdSource { get; set; }
        public string SessionId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public long RelateId { get; set; }
    }
}
