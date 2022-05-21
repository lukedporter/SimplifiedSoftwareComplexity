namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface ILogic : IReadWrite, IFramework
    {
        // Intended for complex logic, possibly involving multiple records, for reading and writing data. Interfaces with Displays and ILogicRecords (inherits from IRecord).
    }
}
