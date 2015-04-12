namespace OneSkyDotNet
{
    public interface IPlatform
    {
        IPlatformPlainClient CreatePlainClient(string publicKey, string secretKey);
    }
}