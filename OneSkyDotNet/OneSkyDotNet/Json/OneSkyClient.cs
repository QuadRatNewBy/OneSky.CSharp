namespace OneSkyDotNet.Json
{
    public class OneSkyClient : IOneSkyClient
    {
        public static IOneSkyClient CreateClient(string publicKey, string secretKey)
        {
            var client = new OneSkyClient();
            client.Plain = OneSkyDotNet.OneSkyClient.CreateClient(publicKey, secretKey);
            client.Platform = new Platform(client.Plain.Platform);
            client.Plugin = new Plugin(client.Plain.Plugin);
            return client;
        }

        public IPlatform Platform { get; private set; }

        public IPlugin Plugin { get; private set; }

        public OneSkyDotNet.IOneSkyClient Plain { get; private set; }
    }
}