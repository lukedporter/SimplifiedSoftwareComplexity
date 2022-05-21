namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    //TODO: Do this other places.
    public interface IDurationRecord : IDurationArchive, IRecord, ITime
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        TimeSpan Duration { get; set; }
        int GetDuration(string secondMinuteHourOrDay);
        bool StartTimeExists();
        bool EndTimeExists();
    }
}