namespace OneSky.CSharp.Json
{
    /// <summary>
    /// Platform API Translation endpoints interface.
    /// </summary>
    public interface IPlatformTranslation
    {
        /// <summary>
        /// Exports translation to the file.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="locale">
        /// Specify language of translations to export.
        /// </param>
        /// <param name="sourceFileName">
        /// Specify the name of the source file.
        /// </param>
        /// <param name="exportFileName">
        /// Specify the name of export file that is the file to be returned.
        /// </param>
        /// <returns>
        /// <para>When translation file is not ready. If the file is not processing, this will trigger the action to create file: <c>202 Accepted</c></para>
        /// <para>When no string is ready in the file: <c>204 No content</c></para>
        /// <para>When translation file is ready: The <see cref="IOneSkyResponse{TMeta,TData}"/> with file content.</para> 
        /// </returns>
        /// <remarks>
        /// This action will create files from translations with specified locale. When translation file is ready, this action will simply response with the file.
        /// </remarks>
        IOneSkyResponse<IMeta, string> Export(int projectId, string locale, string sourceFileName, string exportFileName = null);

        /// <summary>
        /// Exports translation into Multilingual File.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="sourceFileName">
        /// Specify the name of the source file.
        /// </param>
        /// <param name="exportFileName">
        /// Specify the name of export file that is the file to be returned.
        /// </param>
        /// <param name="fileFormat">
        /// <para>Specify export file format, if different from source file format.</para>
        /// <para>Recommend only convert from <c>I18NEXT_HIERARCHICAL_JSON</c>.</para>
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and <see cref ="string"/> as <c>Data</c>.
        /// </returns> 
        /// <remarks>
        /// This action will create files from translations of specified file. When translation file is ready, this action will simply response with the file. Currently supported format is <c>I18NEXT_MULTILINGUAL_JSON</c>.
        /// </remarks>
        IOneSkyResponse<IMeta, string> ExportMultilingualFile(int projectId, string sourceFileName, string exportFileName = null, string fileFormat = null);

        /// <summary>
        /// Exports translation of App Store Description into JSON
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="locale">
        /// Specify language of translations to export.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMetaList"/> as <c>Meta</c> and <see cref="IAppDescription"/> as <c>Data</c>.
        /// </returns>
        /// <remarks>
        /// This action is available for project of App Store Description and will export translations with specified locale in JSON format.
        /// </remarks>
        IOneSkyResponse<IMeta, IAppDescription> AppDescription(int projectId, string locale);

        /// <summary>
        /// Returns the progress of the translation of a specific file.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="fileName">
        /// Specify the name of the source file.
        /// </param>
        /// <param name="locale">
        /// Specify language of translation.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMetaList"/> as <c>Meta</c> and <see cref="ITranslationStatus"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, ITranslationStatus> Status(int projectId, string fileName, string locale);
    }
}