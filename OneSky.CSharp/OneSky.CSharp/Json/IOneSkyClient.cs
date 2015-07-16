namespace OneSkyDotNet.Json
{
    public interface IOneSkyClient
    {
        IPlatform Platform { get; }

        IPlugin Plugin { get; }

        OneSkyDotNet.IOneSkyClient Plain { get; }
    }
}