namespace OneSky.CSharp
{
    /// <summary>
    /// Platform API Import Task endpoints interface.
    /// </summary>
    public interface IPlatformImportTask
    {
        /// <summary>
        /// Lists import tasks of the project.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="page">
        /// <para>Page to retrieve.</para>
        /// <para>(Min. value: 1)</para>
        /// </param>
        /// <param name="perPage">
        /// <para>Import Tasks to retrieve for each page.</para>
        /// <para>(Min. value: 1; Max value: 100)</para>
        /// </param>
        /// <param name="status">
        /// <para>Filter to show only import tasks of specific status with one of the followings:</para>
        /// <list type="bullet">
        ///   <listheader>
        ///     <term>status</term>
        ///     <description>tasks being retrieved</description>
        ///   </listheader>
        ///   <item>
        ///     <term>all</term>
        ///     <description>All tasks</description>
        ///   </item>
        ///   <item>
        ///     <term>completed</term>
        ///     <description>Tasks imported successfully</description>
        ///   </item>
        ///   <item>
        ///     <term>in-progress</term>
        ///     <description>Tasks are being handling or waiting for others to finish</description>
        ///   </item>
        ///   <item>
        ///     <term>failed</term>
        ///     <description>Tasks failed while processing</description>
        ///   </item>
        /// </list>
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse List(int projectId, int page = 1, int perPage = 50, string status = "all");

        /// <summary>
        /// Shows specific import task from the project
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="importTaskId">
        /// Id of the import task.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse Show(int projectId, int importTaskId);
    }
}