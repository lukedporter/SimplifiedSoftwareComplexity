using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;

namespace SimplifiedSoftwareComplexity.Fundamentals
{
    public class SessionRecord : ISessionRecord, ISessionArchive, IWrite
    {

        string ISessionArchive.SessionIdSource { get; set; }
        string ISessionArchive.SessionId { get; set; }



        bool IWrite.Write(dynamic toWrite)
        {
            throw new NotImplementedException();
        }

        bool IWrite.WriteFailure(dynamic toWrite)
        {
            throw new NotImplementedException();
        }

        void IWrite.NotifyWriteFailure(dynamic wasWrite)
        {
            throw new NotImplementedException();
        }

        void ISessionRecord.SetSessionId(string sessionId)
        {
            throw new NotImplementedException();
        }

        void ISessionRecord.SetSessionId(object sessionId)
        {
            throw new NotImplementedException();
        }

        void ISessionRecord.SetSessionId(long sessionId)
        {
            throw new NotImplementedException();
        }

        void ISessionRecord.SetSessionId(int sessionId)
        {
            throw new NotImplementedException();
        }

        dynamic ISessionRecord.GetSessionId()
        {
            throw new NotImplementedException();
        }

        long IRelate.RelateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
