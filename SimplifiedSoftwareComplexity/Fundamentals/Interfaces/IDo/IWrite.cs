namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface IWrite : IDo
    {
        public bool Write(dynamic? toWrite);
        public bool WriteFailure(dynamic? toWrite);
        public void NotifyWriteFailure(dynamic? wasWrite);
    }
}
