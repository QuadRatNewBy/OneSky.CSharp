namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    /// <summary>
    /// Plugin API Locale interface.
    /// </summary>
    public interface IPluginLocale
    {
        /// <summary>
        /// Returns all available locales in the platform.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and list of <see cref="ILocale"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IEnumerable<ILocale>> GetLocales();
    }
}