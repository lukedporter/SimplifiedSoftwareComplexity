namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface IDurationArchive : IArchive, ITime
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        TimeSpan Duration { get; set; }
    }
}
