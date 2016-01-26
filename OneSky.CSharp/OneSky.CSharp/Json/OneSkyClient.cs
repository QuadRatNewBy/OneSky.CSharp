namespace OneSky.CSharp.Json
{
    /// <summary>
    /// <para>OneSky API 'JSON' client.</para>
    /// <para>Returns response body as deserialized JSON <c>object</c>.</para>
    /// </summary>
    public class OneSkyClient : IOneSkyClient
    {
        private static IPluginAnonymous anonymous = new PluginAnonymous(CSharp.OneSkyClient.Anonymous);

        /// <summary>
        /// Provides access to 'Anonymous' endpoints (without creating client instance with your API keys).
        /// </summary>
        public static IPluginAnonymous Anonymous
        {
            get
            {
                return anonymous;
            }
        }

        /// <summary>
        /// Creates instance of OneSky client with your API keys.
        /// </summary>
        /// <param name="publicKey">
        /// Public API key.
        /// </param>
        /// <param name="secretKey">
        /// Secret API key.
        /// </param>
        /// <returns>
        /// JSON OneSky client <see cref="IOneSkyClient"/>.
        /// </returns>
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

        /// <summary>
        /// Provides access to OneSky's 'Platform' API.
        /// </summary>
        public IPlatform Platform { get; private set; }
        
        /// <summary>
        /// Provides access to OneSky's 'Plugin' API.
        /// </summary>
        public IPlugin Plugin { get; private set; }

        /// <summary>
        /// OneSky API 'Plain' client.
        /// </summary>
        public CSharp.IOneSkyClient Plain { get; private set; }
    }
}