namespace OneSkyDotNet
{
    public interface IOneSkyPlatform
    {
        IOneSkyPlatformPlainClient CreatePlainClient(string publicKey, string secretKey);
    }
}