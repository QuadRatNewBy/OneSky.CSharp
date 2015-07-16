namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IPlatformImportTask
    {
        IOneSkyResponse<IMeta, IEnumerable<IImportTaskFile>> List(int projectId, int page = 1, int perPage = 50, string status = "all");

        IOneSkyResponse<IMeta, IImportTaskFileInfo> Show(int projectId, int importTaskId);
    }
}
