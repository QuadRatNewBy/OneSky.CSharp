namespace OneSky.CSharp.Json
{
    public class OneSkyClient : IOneSkyClient
    {
        private static IPluginAnonymous anonymous = new PluginAnonymous(CSharp.OneSkyClient.Anonymous);

        public static IPluginAnonymous Anonymous
        {
            get
            {
                return anonymous;
            }
        }

        public static IOneSkyClient CreateClient(string publicKey, string secretKey)
        {
            var client = new OneSkyClient();
            client.Plain = CSharp.OneSkyClient.CreateClient(publicKey, secretKey);
            client.Platform = new Platform(client.Plain.Platform);
            client.Plugin = new Plugin(client.Plain.Plugin);
            return client;
        }

        private OneSkyClient()
        {
        }

        public IPlatform Platform { get; private set; }

        public IPlugin Plugin { get; private set; }

        public CSharp.IOneSkyClient Plain { get; private set; }
    }
}