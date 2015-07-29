namespace OneSky.CSharp
{
    /// <summary>
    /// Platform API Project endpoints interface.
    /// </summary>
    public interface IPlatformProject
    {
        /// <summary>
        /// Lists all projects in project group.
        /// </summary>
        /// <param name="projectGroupId">
        /// Id of the project group.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse List(int projectGroupId);

        /// <summary>
        /// Shows specific project.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse Show(int projectId);

        /// <summary>
        /// Creates new project in project group.
        /// </summary>
        /// <param name="projectGroupId">
        /// Id of the project group.
        /// </param>
        /// <param name="projectType">
        /// <para>Type of new project.</para>
        /// <para>Can be listed at <c>ProjectType.List</c></para>
        /// </param>
        /// <param name="name">
        /// Name of new project.
        /// </param>
        /// <param name="description">
        /// Description of new project.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse Create(int projectGroupId, string projectType, string name = null, string description = null);

        /// <summary>
        /// Updates details of the project.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="name">
        /// New name of the project.
        /// </param>
        /// <param name="description">
        /// New description of the project.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse Update(int projectId, string name = null, string description = null);

        /// <summary>
        /// Removes project from project group.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse Delete(int projectId);

        /// <summary>
        /// Lists languages presented in specific project.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse Languages(int projectId);
    }
}