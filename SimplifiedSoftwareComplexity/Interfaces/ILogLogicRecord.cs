using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;

namespace SimplifiedSoftwareComplexity.Interfaces
{
    public interface ILogLogicRecord : ILogicRecord, ILog
    {
        ILogRecord LogRecord { get; set; }
        ISessionRecord SessionRecord { get; set; }
        IDurationRecord DurationRecord { get; set; }
    }
}
