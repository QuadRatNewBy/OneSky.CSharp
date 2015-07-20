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
            var plainClient = CSharp.OneSkyClient.CreateClient(publicKey, secretKey);
            var client = new OneSkyClient
                             {
                                 Platform = new Platform(plainClient.Platform),
                                 Plugin = new Plugin(plainClient.Plugin),
                                 Plain = plainClient
                             };
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