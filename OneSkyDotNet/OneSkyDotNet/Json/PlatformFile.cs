namespace OneSkyDotNet.Json
{
    internal class PlatformFile : IPlatformFile
    {
        private OneSkyDotNet.IPlatformFile file;

        public PlatformFile(OneSkyDotNet.IPlatformFile file)
        {
            this.file = file;
        }

        public IOneSkyResponse<IMetaList, IFileDetails> List(int projectId, int page = 1, int perPage = 50)
        {
            throw new System.NotImplementedException();
        }

        public IOneSkyResponse<IMeta, IFileInfoFull> Upload(
            int projectId,
            string file,
            string fileFormat,
            string locale = null,
            bool isKeepingAllStrings = true)
        {
            throw new System.NotImplementedException();
        }

        public IOneSkyResponse<IMeta, IFile> Delete(int projectId, string fileName)
        {
            throw new System.NotImplementedException();
        }
    }
}