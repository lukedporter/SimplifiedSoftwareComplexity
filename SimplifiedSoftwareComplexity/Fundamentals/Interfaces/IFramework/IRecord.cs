namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface IRecord : IArchive, IReadWrite, IFramework
    {
        // Intended to read and write with IArchives. These can be used for simpler implementations of software and can substitue as IDisplays or ViewModels. Interfaces with IArchives and ILogics.
    }
}
