namespace OneSky.CSharp
{
    /// <summary>
    /// Plugin API Quotation Locale interface.
    /// </summary>
    public interface IPluginLocale
    {
        /// <summary>
        /// Returns all available locales in the platform..
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse GetLocales();
    }
}