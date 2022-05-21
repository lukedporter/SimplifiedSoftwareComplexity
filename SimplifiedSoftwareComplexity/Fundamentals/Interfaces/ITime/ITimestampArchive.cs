namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface ITimestampArchive : ITime
    {
        DateTime? Timestamp { get; set; }
    }
}
