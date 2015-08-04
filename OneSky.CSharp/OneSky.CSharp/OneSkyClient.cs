namespace OneSky.CSharp
{
    /// <summary>
    /// <para>OneSky API 'Plain' client.</para>
    /// <para>Returns response body as <c>string</c>.</para>
    /// </summary>
    public class OneSkyClient : IOneSkyClient
    {
        private static readonly IPluginAnonymous anonymous = new PluginAnonymous();

        private OneSkyClient(OneSkyHelper oneSky)
        {
            this.Platform = new Platform(oneSky);
            this.Plugin = new Plugin(oneSky);
        }

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
        /// Provides access to OneSky's 'Platform' API.
        /// </summary>
        public IPlatform Platform { get; private set; }

        /// <summary>
        /// Provides access to OneSky's 'Plugin' API.
        /// </summary>
        public IPlugin Plugin { get; private set; }

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
        /// Plain OneSky client <see cref="IOneSkyClient"/>.
        /// </returns>
        public static IOneSkyClient CreateClient(string publicKey, string secretKey)
        {
            var oneSky = new OneSkyHelper(publicKey, secretKey);
            return new OneSkyClient(oneSky);
        }
    }
}