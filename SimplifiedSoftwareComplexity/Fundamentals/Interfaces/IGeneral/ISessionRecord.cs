namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface ISessionRecord : ISessionArchive, IRecord, IGeneral
    {
        //SessionArchive SessionArchive { get; set; }
        void SetSessionId(string sessionId);
        void SetSessionId(object sessionId);
        void SetSessionId(long sessionId);
        void SetSessionId(int sessionId);
        dynamic? GetSessionId();
        
    }
}
