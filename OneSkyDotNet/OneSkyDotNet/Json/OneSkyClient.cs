namespace OneSkyDotNet.Json
{
    public class OneSkyClient : IOneSkyClient
    {
        public static IOneSkyClient CreateClient(string publicKey, string secretKey)
        {
            return new OneSkyClient();
        }

        public IPlatform Platform { get; private set; }

        public IPlugin Plugin { get; private set; }
    }
}