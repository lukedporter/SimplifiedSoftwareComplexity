using SimplifiedSoftwareComplexity.Fundamentals.Interfaces;

namespace SimplifiedSoftwareComplexity.Fundamentals
{
    public class PageRecord : IPageRecord
    {
        long IRelate.RelateId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IPageRecord.PageName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        object? IPageRecord.PageObject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IPageRecord.OnGitHubAuthentication { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IPageRecord.OnImportExcel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IWrite.NotifyWriteFailure(dynamic wasWrite)
        {
            throw new NotImplementedException();
        }

        bool IWrite.Write(dynamic toWrite)
        {
            throw new NotImplementedException();
        }

        bool IWrite.WriteFailure(dynamic toWrite)
        {
            throw new NotImplementedException();
        }
    }
}
