namespace OneSky.CSharp
{
    /// <summary>
    /// Platform API Locale endpoints interface.
    /// </summary>
    public interface IPlatformLocale
    {
        /// <summary>
        /// Lists all locales.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse List();
    }
}