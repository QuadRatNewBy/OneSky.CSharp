namespace OneSkyDotNet
{
    public interface IOneSkyResponse
    {
        int StatusCode { get; }
        string StatusDescription { get; }
        string Content { get; }
    }
}
