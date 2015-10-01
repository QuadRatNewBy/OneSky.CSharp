namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    /// <summary>
    /// Plugin API Quotation endpoints interface.
    /// </summary>
    public interface IPluginQuotation
    {
        /// <summary>
        /// Returns a list of quotations (sales quote) for the order with partially specified parameters.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="fromLocale">
        /// <para>Language to be translated from.</para>
        /// <para>Default - base locale of the project.</para>
        /// </param>
        /// <param name="toLocales">
        /// List of target languages to translate.
        /// </param>
        /// <param name="items">
        /// <para>Dictionary of items to be translated.</para>
        /// <para>Where <c>key</c> is name of an Item,</para>
        /// <para>And <c>value</c> is <see cref="IItem"/> itself.</para>
        /// </param>
        /// <param name="specialization">
        /// Code of a project specialization.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and list of <see cref="IQuotationPlugin"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IEnumerable<IQuotationPlugin>> PostQuotations(
            int projectId,
            string fromLocale,
            IEnumerable<string> toLocales,
            IDictionary<string, IItem> items,
            string specialization = "general");
    }
}