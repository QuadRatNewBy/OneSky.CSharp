namespace OneSky.CSharp
{
    /// <summary>
    /// Plugin API Language Pair endpoints interface.
    /// </summary>
    public interface IPluginLanguagePair
    {
        /// <summary>
        /// Returns order supported language pairs.
        /// </summary>
        /// <param name="fromLocale">
        /// Locale code of source language.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse GetLanguagePairs(string fromLocale);
    }
}