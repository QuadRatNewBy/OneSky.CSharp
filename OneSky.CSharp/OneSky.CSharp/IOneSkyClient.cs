namespace OneSky.CSharp
{
    public interface IOneSkyClient
    {
        IPlatform Platform { get; }

        IPlugin Plugin { get; }
    }
}