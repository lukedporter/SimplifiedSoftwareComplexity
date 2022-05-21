namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface ITimestamp : ITime
    {
        DateTime? Timestamp { get; set; }
    }
}
