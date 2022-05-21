using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;

namespace SimplifiedSoftwareComplexity.Interfaces
{
    public interface ILogArchive : ISessionArchive, IDurationArchive, IArchive, ILog
    {
        List<string> AllMessages { get; set; }
        string NamespaceName { get; set; }
        string ClassName { get; set; }
        string MethodName { get; set; }
        public object BeginningParameters { get; set; }
        public object EndingParameters { get; set; }
        public int EndIncrement { get; set; }
        public bool OnMethodEndCalled { get; set; }
        public bool IsMethodEnd { get; set; }
    }
}