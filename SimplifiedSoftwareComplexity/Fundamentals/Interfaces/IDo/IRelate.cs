namespace SimplifiedSoftwareComplexity.Fundamentals.Interfaces
{
    public interface IRelate : IDo
    {
        // Intended to identify from one place to another across variables or objects. Such as to map two IArchives together, like how relational databases are designed.
        long RelateId { get; set; }
    }
}
