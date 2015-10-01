namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    /// <summary>
    /// Platform API File endpoints interface.
    /// </summary>
    public interface IPlatformFile
    {
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
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMetaList"/> as <c>Meta</c> and list of <see cref="IFileDetails"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMetaList, IEnumerable<IFileDetails>> List(int projectId, int page = 1, int perPage = 50);

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
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and list of <see cref="IFileInfoFull"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IFileInfoFull> Upload(
            int projectId,
            string file,
            string fileFormat,
            string locale = null,
            bool isKeepingAllStrings = true);

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
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and list of <see cref="IFile"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IFile> Delete(int projectId, string fileName);
    }
}