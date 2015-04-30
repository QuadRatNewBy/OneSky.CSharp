namespace OneSkyDotNet
{
    internal class PlatformPlainTranslation : IPlatformPlainTranslation
    {
        private const string TranslationExportAddress = "https://platform.api.onesky.io/1/projects/{project_id}/translations";
        private const string TranslationExportMultilingualFileAddress = "https://platform.api.onesky.io/1/projects/{project_id}/translations/multilingual";
        private const string TranslationAppDescriptionAddress = "https://platform.api.onesky.io/1/projects/{project_id}/translations/app-descriptions";
        private const string TranslationStatusAddress = "https://platform.api.onesky.io/1/projects/{project_id}/translations/status";

        private const string TranslationExportLocaleParam = "locale";
        private const string TranslationExportSourceFileNameParam = "source_file_name";
        private const string TranslationExportExportFileNameParam = "export_file_name";

        private const string TranslationExportMultilingualFileSourceFileNameParam = "source_file_name";
        private const string TranslationExportMultilingualFileExportFileNameParam = "export_file_name";
        private const string TranslationExportMultilingualFileFormatParam = "file_format";

        private const string TranslationAppDescriptionLocaleParam = "locale";

        private const string ProjectIdPlacehoder = "project_id";

        private OneSky oneSky;

        internal PlatformPlainTranslation(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public string Export(int projectId, string locale, string sourceFileName, string exportFileName = null)
        {
            return this.oneSky.CreateRequest(TranslationExportAddress)
                .Placeholder(ProjectIdPlacehoder, projectId)
                .Parameter(TranslationExportLocaleParam, locale)
                .Parameter(TranslationExportSourceFileNameParam, sourceFileName)
                .Parameter(TranslationExportExportFileNameParam, exportFileName, exportFileName != null)
                .Get();
        }

        public string ExportMultilingualFile(
            int projectId,
            string sourceFileName,
            string exportFileName = null,
            string fileFormat = null)
        {
            return this.oneSky.CreateRequest(TranslationExportMultilingualFileAddress)
                .Placeholder(ProjectIdPlacehoder, projectId)
                .Parameter(TranslationExportMultilingualFileSourceFileNameParam, sourceFileName)
                .Parameter(TranslationExportMultilingualFileExportFileNameParam, exportFileName, exportFileName != null)
                .Parameter(TranslationExportMultilingualFileFormatParam, fileFormat, fileFormat != null)
                .Get();
        }

        public string AppDescription(int projectId, string locale)
        {
            return
                this.oneSky.CreateRequest(TranslationAppDescriptionAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Parameter(TranslationAppDescriptionLocaleParam, locale)
                    .Get();
        }

        public string Status(int projectId, string fileName, string locale)
        {
            throw new System.NotImplementedException();
        }
    }
}