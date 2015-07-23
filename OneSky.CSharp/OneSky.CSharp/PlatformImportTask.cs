namespace OneSky.CSharp
{
    /// <summary>
    /// Platform API Import Task endpoints object.
    /// </summary>
    internal class PlatformImportTask : IPlatformImportTask
    {
        /// <summary>
        /// The import task list address.
        /// </summary>
        private const string ImportTaskListAddress = "https://platform.api.onesky.io/1/projects/{project_id}/import-tasks";

        /// <summary>
        /// The import task show address.
        /// </summary>
        private const string ImportTaskShowAddress = "https://platform.api.onesky.io/1/projects/{project_id}/import-tasks/{import_id}";

        /// <summary>
        /// The import task list page parameter.
        /// </summary>
        private const string ImportTaskListPageParam = "page";

        /// <summary>
        /// The import task list per page parameter.
        /// </summary>
        private const string ImportTaskListPerPageParam = "per_page";

        /// <summary>
        /// The import task list status parameter.
        /// </summary>
        private const string ImportTaskListStatusParam = "status";

        /// <summary>
        /// The project id placeholder.
        /// </summary>
        private const string ProjectIdPlaceholder = "project_id";

        /// <summary>
        /// The import task id placeholder.
        /// </summary>
        private const string ImportTaskIdPlaceholder = "import_id";

        /// <summary>
        /// The OneSky helper.
        /// </summary>
        private readonly OneSkyHelper oneSky;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformImportTask"/> class.
        /// </summary>
        /// <param name="oneSky">
        /// The OneSky helper.
        /// </param>
        internal PlatformImportTask(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

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
        /// <para>Files to retrieve for each page.</para>
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
        public IOneSkyResponse List(int projectId, int page = 1, int perPage = 50, string status = "all")
        {
            return this.oneSky.CreateRequest(ImportTaskListAddress)
                .Placeholder(ProjectIdPlaceholder, projectId)
                .Parameter(ImportTaskListPageParam, page)
                .Parameter(ImportTaskListPerPageParam, perPage)
                .Parameter(ImportTaskListStatusParam, status)
                .Get();
        }

        /// <summary>
        /// Shows certain import task from the project
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
        public IOneSkyResponse Show(int projectId, int importTaskId)
        {
            return
                this.oneSky.CreateRequest(ImportTaskShowAddress)
                    .Placeholder(ProjectIdPlaceholder, projectId)
                    .Placeholder(ImportTaskIdPlaceholder, importTaskId)
                    .Get();
        }
    }
}