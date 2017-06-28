namespace OneSky.CSharp
{
    /// <summary>
    /// Plugin API Anonymous Account endpoints (i.e. accessible without API keys) interface.
    /// </summary>
    public interface IPluginAnonymous
    {
        /// <summary>
        /// Register account in OneSky.
        /// </summary>
        /// <param name="email">
        /// User Email to register account.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        /// <remarks>
        /// Password will be sent to Email specified in <paramref name="email"/> parameter.
        /// </remarks>
        IOneSkyResponse SignUp(string email);

        /// <summary>
        /// Login to OneSky account.
        /// </summary>
        /// <param name="email">
        /// User email.
        /// </param>
        /// <param name="password">
        /// Account password.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse SignIn(string email, string password);
    }
}