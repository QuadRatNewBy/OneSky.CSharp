namespace OneSky.CSharp.Json
{
    public interface IOneSkyResponse<out TMeta, out TData>
    {
        int StatusCode { get; }

        string StatusDescription { get; }

        TMeta Meta { get; }

        TData Data { get; }
    }
}
