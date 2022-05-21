namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface IDisplay : ILogic, IRead, IFramework
    {
        // Intended only for complex logic related to displaying information. Interfaces with ILogics. These can also be known as ViewModels. An ILogic does not need to have an IDisplay, as it could just be used as backend code and not for display purposes.
    }
}
