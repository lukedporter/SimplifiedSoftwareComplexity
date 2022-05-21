using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;

namespace SimplifiedSoftwareComplexity.Fundamentals
{
    public class DurationArchive : IDurationArchive
    {
        long IRelate.RelateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime IDurationArchive.StartTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime IDurationArchive.EndTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        TimeSpan IDurationArchive.Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
