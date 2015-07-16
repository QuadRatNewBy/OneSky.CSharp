namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    internal class PlatformFile : IPlatformFile
    {
        private OneSkyDotNet.IPlatformFile platformFile;

        public PlatformFile(OneSkyDotNet.IPlatformFile file)
        {
            this.platformFile = file;
        }

        public IOneSkyResponse<IMetaList, IEnumerable<IFileDetails>> List(int projectId, int page = 1, int perPage = 50)
        {
            var plain = this.platformFile.List(projectId, page, perPage);
            return JsonHelper.PlatformCompose<IMetaList, IEnumerable<IFileDetails>, MetaList, List<FileDetails>>(plain);
        }

        public IOneSkyResponse<IMeta, IFileInfoFull> Upload(
            int projectId,
            string file,
            string fileFormat,
            string locale = null,
            bool isKeepingAllStrings = true)
        {
            var plain = this.platformFile.Upload(projectId, file, fileFormat, locale, isKeepingAllStrings);
            return JsonHelper.PlatformCompose<IMeta, IFileInfoFull, Meta, FileInfoFull>(plain);
        }

        public IOneSkyResponse<IMeta, IFile> Delete(int projectId, string fileName)
        {
            var plain = this.platformFile.Delete(projectId, fileName);
            return JsonHelper.PlatformCompose<IMeta, IFile, Meta, File>(plain);
        }
    }
}