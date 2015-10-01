namespace OneSky.CSharp.Json
{
    /// <summary>
    /// <para>OneSky API 'JSON' client interface.</para>
    /// <para>Returns response body as deserialized JSON <c>object</c>.</para>
    /// </summary>
    public interface IOneSkyClient
    {
        /// <summary>
        /// Provides access to OneSky's 'Platform' API.
        /// </summary>
        IPlatform Platform { get; }

        /// <summary>
        /// Provides access to OneSky's 'Plugin' API.
        /// </summary>
        IPlugin Plugin { get; }

        /// <summary>
        /// OneSky API 'Plain' client.
        /// </summary>
        CSharp.IOneSkyClient Plain { get; }
    }
}