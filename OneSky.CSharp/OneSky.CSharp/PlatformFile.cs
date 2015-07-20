namespace OneSky.CSharp
{
    internal class PlatformFile : IPlatformFile
    {
        private const string FileListAddress = "https://platform.api.onesky.io/1/projects/{project_id}/files";
        private const string FileUploadAddress = "https://platform.api.onesky.io/1/projects/{project_id}/files";
        private const string FileDeleteAddress = "https://platform.api.onesky.io/1/projects/{project_id}/files";
        
        private const string FileListPageParam = "page";
        private const string FileListPerPageParam = "per_page";

        private const string FileUploadFileFile = "file";
        private const string FileUploadFileFormatBody = "file_format";
        private const string FileUploadLocaleBody = "locale";
        private const string FileUploadIsKeepingAllStringsBody = "is_keeping_all_strings";

        private const string FileDeleteFileNameParameter = "file_name";

        private const string ProjectIdPlacehoder = "project_id";

        private OneSkyHelper oneSky;

        internal PlatformFile(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse List(int projectId, int page = 1, int perPage = 50)
        {
            return
                this.oneSky.CreateRequest(FileListAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Parameter(FileListPageParam, page)
                    .Parameter(FileListPerPageParam, perPage)
                    .Get();
        }

        public IOneSkyResponse Upload(int projectId, string file, string fileFormat, string locale = null, bool isKeepingAllStrings = true)
        {
            return
                this.oneSky.CreateRequest(FileUploadAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Files(FileUploadFileFile, file)
                    .Body(FileUploadFileFormatBody, fileFormat)
                    .Body(FileUploadLocaleBody, locale, locale != null)
                    .Body(FileUploadIsKeepingAllStringsBody, isKeepingAllStrings)
                    .Post();
        }

        public IOneSkyResponse Delete(int projectId, string fileName)
        {
            return
                this.oneSky.CreateRequest(FileDeleteAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Parameter(FileDeleteFileNameParameter, fileName)
                    .Delete();
        }
    }
}