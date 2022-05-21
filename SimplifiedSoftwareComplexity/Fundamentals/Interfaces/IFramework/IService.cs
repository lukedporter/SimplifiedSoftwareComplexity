namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface IService : IFramework
    {
        // Justification for HTTPClient used: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-6.0#typed-clients
        // To indicate something is a service where it centrally handles either network or data connections.
    }
}
