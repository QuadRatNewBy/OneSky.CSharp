namespace OneSkyDotNet.Json
{
    public interface IAccount
    {
        string Name { get; }

        string ApiKey { get; }

        string ApiSecret { get; } 
    }
}