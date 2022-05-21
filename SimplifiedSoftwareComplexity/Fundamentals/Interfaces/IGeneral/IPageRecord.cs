namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface IPageRecord : IRecord, IGeneral // See how this is simplified with an IRecord?
    {
        string PageName { get; set; }
        object? PageObject { get; set; } //TODO: Every page should probably have a LogWriter.
        bool OnGitHubAuthentication { get; set; }
        bool OnImportExcel { get; set; }
    }
}
