namespace OneSkyDotNet
{
    public interface IOneSkyClient
    {
        IPlatform Platform { get; }

        IPlugin Plugin { get; }
    }
}