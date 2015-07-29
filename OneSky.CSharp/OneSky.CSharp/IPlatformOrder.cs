namespace OneSky.CSharp
{
    using System.Collections.Generic;

    /// <summary>
    /// Platform API Order endpoints interface.
    /// </summary>
    public interface IPlatformOrder
    {
        /// <summary>
        /// Lists all orders in the project.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="page">
        /// <para>Page to retrieve.</para>
        /// <para>(Min. value: 1)</para>
        /// </param>
        /// <param name="perPage">
        /// <para>Orders to retrieve for each page.</para>
        /// <para>(Min. value: 1; Max. value: 100)</para>
        /// </param>
        /// <param name="fileName">
        /// Filter orders by file name.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse List(int projectId, int page = 1, int perPage = 50, string fileName = null);

        /// <summary>
        /// Shows specific order from the project
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="orderId">
        /// Id of the order.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse Show(int projectId, int orderId);

        /// <summary>
        /// Creates new order for the project.
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
        /// <param name="orderType">
        /// <para>Specify type of order:</para>
        /// <list type="bullet">
        ///   <listheader>
        ///     <term>type</term>
        ///     <description>description</description>
        ///   </listheader>
        ///   <item>
        ///     <term>translate-only</term>
        ///     <description>perform translation only</description>
        ///   </item>
        ///   <item>
        ///     <term>review-only</term>
        ///     <description>review translation only</description>
        ///   </item>
        ///   <item>
        ///     <term>translate-review</term>
        ///     <description>perform translation and review afterwards</description>
        ///   </item>
        /// </list>
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
        /// <param name="translatorType">
        /// <para>Specify type of translator used in translation:</para>
        /// <list type="bullet">
        ///   <listheader>
        ///     <term>type</term>
        ///     <description>description</description>
        ///   </listheader>
        ///   <item>
        ///     <term>preferred</term>
        ///     <description>select translator who helped translated your projects previously for consistency</description>
        ///   </item>
        ///   <item>
        ///     <term>fastest</term>
        ///     <description>select translator who has fewest jobs and is able to pick up your job faster</description>
        ///   </item>
        /// </list>
        /// </param>
        /// <param name="tone">
        /// <para>Specify the tone used in translation:</para>
        /// <list type="bullet">
        ///   <listheader>
        ///     <term>tone</term>
        ///     <description>description</description>
        ///   </listheader>
        ///   <item>
        ///     <term>not-specified</term>
        ///     <description>no preference</description>
        ///   </item>
        ///   <item>
        ///     <term>formal</term>
        ///     <description>translate in formal tone</description>
        ///   </item>
        ///   <item>
        ///     <term>informal</term>
        ///     <description>translate in informal tone</description>
        ///   </item>
        /// </list>
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
        /// <param name="note">
        /// Note to translator.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse Create(
            int projectId,
            IEnumerable<string> files,
            string toLocale,
            string orderType = "translate-only",
            bool isIncludingNotTranslated = true,
            bool isIncludingNotApproved = true,
            bool isIncludingOutdated = true,
            string translatorType = "preferred",
            string tone = "not-specified",
            string specialization = "general",
            string note = null);
    }
}