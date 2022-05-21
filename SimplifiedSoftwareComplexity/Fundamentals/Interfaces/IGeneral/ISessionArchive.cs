namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface ISessionArchive : IArchive, IGeneral
    {
        public string SessionIdSource { get; set; }
        public string SessionId { get; set; }
    }
}
