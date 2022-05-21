using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;

namespace SimplifiedSoftwareComplexity.Interfaces
{
    public interface ILogLogic : ILogic, ILog
    {
        ILogLogicRecord LogLogicRecord { get; set; }
        public bool Initializing { get; set; }
        public void OnNewMessage(string newMessage);
        public void OnNewMessage(object newMessage);
        public bool OnEndLog(object endingParamters);
        public bool ArchiveRecord();
        public bool Cleanup();
    }
}
