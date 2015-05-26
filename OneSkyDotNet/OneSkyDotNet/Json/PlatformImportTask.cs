namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public class PlatformImportTask : IPlatformImportTask
    {
        private OneSkyDotNet.IPlatformImportTask importTask;

        public PlatformImportTask(OneSkyDotNet.IPlatformImportTask importTask)
        {
            this.importTask = importTask;
        }

        public IOneSkyResponse<IMeta, IEnumerable<IImportTaskFile>> List(int projectId, int page = 1, int perPage = 50, string status = "all")
        {
            var plain = this.importTask.List(projectId, page, perPage, status);
            return JsonHelper.PlatformCompose<IMeta, IEnumerable<IImportTaskFile>, Meta, List<ImportTaskFile>>(plain);
        }

        public IOneSkyResponse<IMeta, IImportTaskFileInfo> Show(int projectId, int importTaskId)
        {
            var plain = this.importTask.Show(projectId, importTaskId);
            return JsonHelper.PlatformCompose<IMeta, IImportTaskFileInfo, Meta, ImportTaskFileInfo>(plain);
        }
    }
}