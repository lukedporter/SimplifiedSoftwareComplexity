namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface ILogic : ILogicRecord, IReadWrite, IFramework
    {
        // Intended for complex logic, possibly involving multiple records, for reading and writing data. Interfaces with IDisplays (optionally, see IDisplay) and ILogicRecords (inherits from IRecord).
    }
}
