namespace OneSky.CSharp
{
    /// <summary>
    /// Plugin API Order endpoints interface.
    /// </summary>
    public interface IPluginOrder
    {
        /// <summary>
        /// Lists all orders in the project.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="page">
        /// <para>Page to retrieve.</para>
        /// <para>(Default: 1)</para>
        /// </param>
        /// <param name="perPage">
        /// <para>Items to retrieve for each page.</para>
        /// <para>(Default: 15)</para>
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse GetOrders(int projectId, int page = 1, int perPage = 15);

        /// <summary>
        /// Returns details of the order.
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
        IOneSkyResponse GetOrder(int projectId, int orderId);

        /// <summary>
        /// Lists order's items.
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
        IOneSkyResponse GetOrderItems(int projectId, int orderId);

        /// <summary>
        /// Lists order's messages.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="orderId">
        /// Id of the order.
        /// </param>
        /// <param name="page">
        /// <para>Page to retrieve.</para>
        /// <para>(Default: 1)</para>
        /// </param>
        /// <param name="perPage">
        /// <para>Items to retrieve for each page.</para>
        /// <para>(Default: 15)</para>
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse GetOrderMessages(int projectId, int orderId, int page = 1, int perPage = 15);

        /// <summary>
        /// Send an order to professional translators.
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
        /// <param name="tone">
        /// <para>Tone of the translation.</para>
        /// <para><c>FORMAL</c> or <c>INFORMAL</c> (default not specified).</para>
        /// </param>
        /// <param name="note">
        /// Note for translator about the order.
        /// </param>
        /// <param name="isIncludingReview">
        /// Is translation review required.
        /// </param>
        /// <param name="specialization">
        /// Code of a project specialization.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse PostOrders(
            int projectId,
            string fromLocale,
            string toLocales,
            string items,
            string tone = null,
            string note = null,
            bool isIncludingReview = false,
            string specialization = "general");
    }
}