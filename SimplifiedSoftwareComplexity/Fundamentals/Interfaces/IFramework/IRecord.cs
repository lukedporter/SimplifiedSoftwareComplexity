namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface IRecord : IArchive, IReadWrite, IFramework
    {
        // Intended to read and write with IArchives. Interfaces with IArchives, IDisplays, and ILogics.
    }
}
