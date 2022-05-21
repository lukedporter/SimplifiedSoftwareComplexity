namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface IAppRecord : IRecord, IGeneral
    {
        string AppName { get; set; }
        SessionRecord SessionRecord { get; set; }
        ITimeLogic TimeRecord { get; set; } // TODO: Decide if we want an ITimeLogic here.
    }
}
