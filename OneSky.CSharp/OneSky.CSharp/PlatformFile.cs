namespace OneSky.CSharp
{
    /// <summary>
    /// Platform API File endpoints object.
    /// </summary>
    internal class PlatformFile : IPlatformFile
    {
        /// <summary>
        /// The file list address.
        /// </summary>
        private const string FileListAddress = "https://platform.api.onesky.io/1/projects/{project_id}/files";

        /// <summary>
        /// The file upload address.
        /// </summary>
        private const string FileUploadAddress = "https://platform.api.onesky.io/1/projects/{project_id}/files";

        /// <summary>
        /// The file delete address.
        /// </summary>
        private const string FileDeleteAddress = "https://platform.api.onesky.io/1/projects/{project_id}/files";

        /// <summary>
        /// The file list page parameter.
        /// </summary>
        private const string FileListPageParam = "page";

        /// <summary>
        /// The file list per page parameter.
        /// </summary>
        private const string FileListPerPageParam = "per_page";

        /// <summary>
        /// The file upload file file.
        /// </summary>
        private const string FileUploadFileFile = "file";

        /// <summary>
        /// The file upload file format body.
        /// </summary>
        private const string FileUploadFileFormatBody = "file_format";

        /// <summary>
        /// The file upload locale body.
        /// </summary>
        private const string FileUploadLocaleBody = "locale";

        /// <summary>
        /// The file upload is keeping all strings body.
        /// </summary>
        private const string FileUploadIsKeepingAllStringsBody = "is_keeping_all_strings";

        /// <summary>
        /// The file delete file name parameter.
        /// </summary>
        private const string FileDeleteFileNameParameter = "file_name";

        /// <summary>
        /// The project id placeholder.
        /// </summary>
        private const string ProjectIdPlaceholder = "project_id";

        /// <summary>
        /// The OneSky helper.
        /// </summary>
        private readonly OneSkyHelper oneSky;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformFile"/> class.
        /// </summary>
        /// <param name="oneSky">
        /// The OneSky helper
        /// </param>
        internal PlatformFile(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        /// <summary>
        /// Lists all files in the project.
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
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        public IOneSkyResponse List(int projectId, int page = 1, int perPage = 50)
        {
            return
                this.oneSky.CreateRequest(FileListAddress)
                    .Placeholder(ProjectIdPlaceholder, projectId)
                    .Parameter(FileListPageParam, page)
                    .Parameter(FileListPerPageParam, perPage)
                    .Get();
        }

        /// <summary>
        /// Uploads file to the project and starts import task.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="file">
        /// Path to uploading file.
        /// </param>
        /// <param name="fileFormat">
        /// Format of the file.
        /// </param>
        /// <param name="locale">
        /// Specifies language of the file. If locale is different from base language, the strings will add to translation strings.
        /// </param>
        /// <param name="isKeepingAllStrings">
        /// <para>For strings that cannot be found in newly uploaded file with same file name, keep those strings unchanged if set to true. Deprecate those strings if set to false.</para>
        /// <para>Notice that different files will not interfere each other in the same project. For example, with setting is_keeping_all_strings to false, uploading en2.po will not deprecate strings of previously uploaded file, en.po.</para>
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        public IOneSkyResponse Upload(int projectId, string file, string fileFormat, string locale = null, bool isKeepingAllStrings = true)
        {
            return
                this.oneSky.CreateRequest(FileUploadAddress)
                    .Placeholder(ProjectIdPlaceholder, projectId)
                    .Files(FileUploadFileFile, file)
                    .Body(FileUploadFileFormatBody, fileFormat)
                    .Body(FileUploadLocaleBody, locale, locale != null)
                    .Body(FileUploadIsKeepingAllStringsBody, isKeepingAllStrings)
                    .Post();
        }

        /// <summary>
        /// Deletes a File from project.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="fileName">
        /// Name of file to delete
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        public IOneSkyResponse Delete(int projectId, string fileName)
        {
            return
                this.oneSky.CreateRequest(FileDeleteAddress)
                    .Placeholder(ProjectIdPlaceholder, projectId)
                    .Parameter(FileDeleteFileNameParameter, fileName)
                    .Delete();
        }
    }
}