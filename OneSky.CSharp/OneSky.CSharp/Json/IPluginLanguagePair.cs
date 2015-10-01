namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

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
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and list of <see cref="ILocale"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IEnumerable<ILocale>> GetLanguagePairs(string fromLocale);
    }
}