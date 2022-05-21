namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface IChangeArchive : IArchive, IGeneral
    {
        string CreatedByUserId { get; set; }
        DateTime CreatedByTimestamp { get; set; }
        string ModifiedByUserId { get; set; }
        DateTime ModifiedByTimestamp { get; set; }
    }
}
