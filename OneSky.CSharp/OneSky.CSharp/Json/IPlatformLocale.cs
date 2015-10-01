namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    /// <summary>
    /// Platform API Locale endpoints interface.
    /// </summary>
    public interface IPlatformLocale
    {
        /// <summary>
        /// Lists all locales.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMetaList"/> as <c>Meta</c> and list of <see cref="ILocale"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMetaList, IEnumerable<ILocale>> List();
    }
}