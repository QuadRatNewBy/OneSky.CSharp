namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    /// <summary>
    /// Platform API Project Group endpoints interface.
    /// </summary>
    public interface IPlatformProjectGroup
    {
        /// <summary>
        /// Lists all project groups.
        /// </summary>
        /// <param name="page">
        /// <para>Page to retrieve.</para>
        /// <para>(Min. value: 1)</para>
        /// </param>
        /// <param name="perPage">
        /// <para>Project Groups to retrieve for each page.</para>
        /// <para>(Min. value: 1; Max. value: 100)</para>
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMetaPagedList"/> as <c>Meta</c> and list of <see cref="IProjectGroup"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMetaPagedList, IEnumerable<IProjectGroup>> List(int page = 1, int perPage = 50);

        /// <summary>
        /// Shows specific project group.
        /// </summary>
        /// <param name="projectGroupId">
        /// Id of the project group.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and <see cref="IProjectGroupDetails"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IProjectGroupDetails> Show(int projectGroupId);

        /// <summary>
        /// Creates new project group.
        /// </summary>
        /// <param name="name">
        /// Name of the project group.
        /// </param>
        /// <param name="locale">
        /// Locale code of the project group base language.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and <see cref="IProjectGroupNew"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IProjectGroupNew> Create(string name, string locale = "en");

        /// <summary>
        /// Removes a project group.
        /// </summary>
        /// <param name="projectGroupId">
        /// Id of the project group.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and no <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, INull> Delete(int projectGroupId);

        /// <summary>
        /// Lists enabled languages of the project group.
        /// </summary>
        /// <param name="projectGroupId">
        /// Id of the project group.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMetaList"/> as <c>Meta</c> and list of <see cref="ILocaleGroup"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMetaList, IEnumerable<ILocaleGroup>> Languages(int projectGroupId);
    }
}