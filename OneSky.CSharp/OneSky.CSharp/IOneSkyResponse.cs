namespace OneSky.CSharp
{
    public interface IOneSkyResponse
    {
        int StatusCode { get; }
        string StatusDescription { get; }
        string Content { get; }
    }
}
