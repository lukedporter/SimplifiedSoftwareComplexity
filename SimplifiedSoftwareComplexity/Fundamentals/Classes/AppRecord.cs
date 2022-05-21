using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;

namespace SimplifiedSoftwareComplexity.Fundamentals
{
    public class AppRecord : IAppRecord
    {
        string IAppRecord.AppName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        SessionRecord IAppRecord.SessionRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ITimeLogic IAppRecord.TimeRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        long IRelate.RelateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IWrite.NotifyWriteFailure(dynamic wasWrite)
        {
            throw new NotImplementedException();
        }

        bool IWrite.Write(dynamic toWrite)
        {
            throw new NotImplementedException();
        }

        bool IWrite.WriteFailure(dynamic toWrite)
        {
            throw new NotImplementedException();
        }
    }
}
