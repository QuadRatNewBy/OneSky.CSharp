namespace OneSky.CSharp.Json
{
    public interface IOneSkyClient
    {
        IPlatform Platform { get; }

        IPlugin Plugin { get; }

        CSharp.IOneSkyClient Plain { get; }
    }
}