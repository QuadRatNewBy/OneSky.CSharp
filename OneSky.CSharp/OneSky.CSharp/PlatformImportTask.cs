namespace OneSky.CSharp
{
    internal class PlatformImportTask : IPlatformImportTask
    {
        private const string ImportTaskListAddress = "https://platform.api.onesky.io/1/projects/{project_id}/import-tasks";
        private const string ImportTaskShowAddress = "https://platform.api.onesky.io/1/projects/{project_id}/import-tasks/{import_id}";

        private const string ImportTaskListPageParam = "page";
        private const string ImportTaskListPerPageParam = "per_page";
        private const string ImportTaskListStatusParam = "status";

        private const string ProjectIdPlacehoder = "project_id";
        private const string ImportTaskIdPlacehoder = "import_id";

        private OneSky oneSky;

        internal PlatformImportTask(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse List(int projectId, int page = 1, int perPage = 50, string status = "all")
        {
            return this.oneSky.CreateRequest(ImportTaskListAddress)
                .Placeholder(ProjectIdPlacehoder, projectId)
                .Parameter(ImportTaskListPageParam, page)
                .Parameter(ImportTaskListPerPageParam, perPage)
                .Parameter(ImportTaskListStatusParam, status)
                .Get();
        }

        public IOneSkyResponse Show(int projectId, int importTaskId)
        {
            return
                this.oneSky.CreateRequest(ImportTaskShowAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Placeholder(ImportTaskIdPlacehoder, importTaskId)
                    .Get();
        }
    }
}