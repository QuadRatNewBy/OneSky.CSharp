namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

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
        /// </param>
        /// <param name="perPage">
        /// <para>Items to retrieve for each page.</para>
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and list of <see cref="IOrderPlugin"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IEnumerable<IOrderPlugin>> GetOrders(int projectId, int page = 1, int perPage = 15);

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
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and <see cref="IOrderPluginDetails"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IOrderPluginDetails> GetOrder(int projectId, int orderId);

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
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and list of <see cref="IItemDetails"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IEnumerable<IItemDetails>> GetOrderItems(int projectId, int orderId);

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
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and list of <see cref="IMessage"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IEnumerable<IMessage>> GetOrderMessages(int projectId, int orderId, int page = 1, int perPage = 15);

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
        /// List of target languages to translate.
        /// </param>
        /// <param name="items">
        /// <para>Dictionary of items to be translated.</para>
        /// <para>Where <c>key</c> is name of an Item,</para>
        /// <para>And <c>value</c> is <see cref="IItem"/> itself.</para>
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
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and <see cref="IOrderPluginNew"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IOrderPluginNew> PostOrders(
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