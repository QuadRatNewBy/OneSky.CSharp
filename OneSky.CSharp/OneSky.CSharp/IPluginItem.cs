namespace OneSky.CSharp
{
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
        /// <para>(Default: 1)</para>
        /// </param>
        /// <param name="perPage">
        /// <para>Items to retrieve for each page.</para>
        /// <para>(Default: 15)</para>
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse GetItems(int projectId, string locale = null, int page = 1, int perPage = 15);

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
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse GetItem(int projectId, int itemId);

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
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse DeleteItem(int projectId, int itemId);
    }
}