namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface IAction : IDo
    {
        // Actions to associated with data for backend jobs, like Azure Functions, such as for databases.
        enum ActionDefinitions { }
        string? Action { get; set; }
    }
}
