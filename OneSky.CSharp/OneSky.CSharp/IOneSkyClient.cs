namespace OneSky.CSharp
{
    /// <summary>
    /// <para>OneSky API 'Plain' client interface.</para>
    /// <para>Returns response body as <c>string</c>.</para>
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
    }
}