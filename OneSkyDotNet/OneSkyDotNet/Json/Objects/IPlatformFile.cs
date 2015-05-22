namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IPlatformFile
    {
        IOneSkyResponse<IMetaList, IEnumerable<IFileDetails>> List(int projectId, int page = 1, int perPage = 50);

        IOneSkyResponse<IMeta, IFileInfoFull> Upload(
            int projectId,
            string file,
            string fileFormat,
            string locale = null,
            bool isKeepingAllStrings = true);

        IOneSkyResponse<IMeta, IFile> Delete(int projectId, string fileName);
    }
}