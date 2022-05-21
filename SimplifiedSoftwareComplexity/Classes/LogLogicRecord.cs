using SimplifiedSoftwareComplexity.Fundamentals;
using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;
using SimplifiedSoftwareComplexity.Interfaces;

namespace SimplifiedSoftwareComplexity.Classes
{
    public class LogLogicRecord : ILogLogicRecord
    {
        public LogRecord LogRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } // This is where I think the magic can happen.
        public ISessionRecord SessionRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } // Here too.
        public IDurationRecord DurationRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } // And here too.
        public long RelateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } // And let us not forget about this one.
        ILogRecord ILogLogicRecord.LogRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void NotifyWriteFailure(dynamic? wasWrite)
        {
            throw new NotImplementedException();
        }

        public bool Write(dynamic? toWrite)
        {
            throw new NotImplementedException();
        }

        public bool WriteFailure(dynamic? toWrite)
        {
            throw new NotImplementedException();
        }
    }
}
