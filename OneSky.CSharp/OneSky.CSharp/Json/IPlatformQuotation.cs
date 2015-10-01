namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    /// <summary>
    /// Platform API Quotation endpoints interface.
    /// </summary>
    public interface IPlatformQuotation
    {
        /// <summary>
        /// Shows a quotation (sales quote) for the order with specified parameters.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="files">
        /// Files to be translated in the order.
        /// </param>
        /// <param name="toLocale">
        /// Target language to translate.
        /// </param>
        /// <param name="isIncludingNotTranslated">
        /// Include not translated phrases to translate.
        /// </param>
        /// <param name="isIncludingNotApproved">
        /// Include not approved phrases to translate.
        /// </param>
        /// <param name="isIncludingOutdated">
        /// Include outdated phrases to translate that is updated since last order.
        /// </param>
        /// <param name="specialization">
        /// <para>Specify specialization in order to translate phrases in a specific area:</para>
        /// <list type="bullet">
        ///   <listheader>
        ///     <term>specialization</term>
        ///     <description>description</description>
        ///   </listheader>
        ///   <item>
        ///     <term>general</term>
        ///     <description>general translations</description>
        ///   </item>
        ///   <item>
        ///     <term>game</term>
        ///     <description>translations of game</description>
        ///   </item>
        /// </list>
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and <see cref="IQuotationPlatform"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IQuotationPlatform> Show(
            int projectId,
            IEnumerable<string> files,
            string toLocale,
            bool isIncludingNotTranslated = true,
            bool isIncludingNotApproved = true,
            bool isIncludingOutdated = true,
            string specialization = "general"); 
    }
}