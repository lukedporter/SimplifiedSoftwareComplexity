using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;

namespace SimplifiedSoftwareComplexity.Fundamentals
{
    public class SessionArchive : ISessionArchive
    {
        long IRelate.RelateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ISessionArchive.SessionIdSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ISessionArchive.SessionId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
