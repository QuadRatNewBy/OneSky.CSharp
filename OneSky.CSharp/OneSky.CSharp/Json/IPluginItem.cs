namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    /// <summary>
    /// Plugin API Item endpoints interface.
    /// </summary>
    public interface IPluginItem
    {
        /// <summary>
        /// Lists all items in the project.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="locale">
        /// <para>Locale code for the items to display.</para>
        /// <para>Default - base language of the project.</para>
        /// </param>
        /// <param name="page">
        /// <para>Page to retrieve.</para>
        /// </param>
        /// <param name="perPage">
        /// <para>Items to retrieve for each page.</para>
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and list of <see cref="IItemEntry"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IEnumerable<IItemEntry>> GetItems(
            int projectId,
            string locale = null,
            int page = 1,
            int perPage = 15);

        /// <summary>
        /// Returns the specified item attributes.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="itemId">
        /// Id of the item.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and <see cref="IItemDetails"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IItemDetails> GetItem(int projectId, int itemId);

        /// <summary>
        /// Deletes the specified item.
        /// </summary>
        /// <param name="projectId">
        /// The project id.
        /// </param>
        /// <param name="itemId">
        /// The item id.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and no <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, INull> DeleteItem(int projectId, int itemId);
    }
}