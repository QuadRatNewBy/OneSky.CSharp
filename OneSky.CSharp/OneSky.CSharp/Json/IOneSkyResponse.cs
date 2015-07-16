namespace OneSky.CSharp.Json
{
    public interface IOneSkyResponse<TMeta, TData>
    {
        int StatusCode { get; }

        string StatusDescription { get; }

        TMeta MetaContent { get; }

        TData DataContent { get; }
    }
}
