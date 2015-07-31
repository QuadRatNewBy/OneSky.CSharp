namespace OneSky.CSharp
{
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
        /// Target languages to translate (comma-separated).
        /// </param>
        /// <param name="items">
        /// Strings to be translated in <c>Item</c> format.
        /// </param>
        /// <param name="specialization">
        /// Code of a project specialization.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse PostQuotations(int projectId, string fromLocale, string toLocales, string items, string specialization = "general");
    }
}