namespace OneSky.CSharp.Json
{
    public interface IMetaPagedList : IMetaList
    {
        int PageCount { get; }

        string NextPage { get; }

        string PreviousPage { get; }

        string FirstPage { get; }

        string LastPage { get; }
    }
}