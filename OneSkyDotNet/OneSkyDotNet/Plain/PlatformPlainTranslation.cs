namespace OneSkyDotNet
{
    internal class PlatformPlainTranslation : IPlatformPlainTranslation
    {
        private const string TranslationExportAddress = "https://platform.api.onesky.io/1/projects/{project_id}/translations";
        private const string TranslationExportMultilingualFile = "https://platform.api.onesky.io/1/projects/{project_id}/translations/multilingual";
        private const string TranslationAppDescription = "https://platform.api.onesky.io/1/projects/{project_id}/translations/app-descriptions";
        private const string TranslationStatus = "https://platform.api.onesky.io/1/projects/{project_id}/translations/status";

        private const string TranslationExportLocaleParam = "locale";
        private const string TranslationExportSourceFileNameParam = "source_file_name";
        private const string TranslationExportExportFileNameParam = "export_file_name";

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
            throw new System.NotImplementedException();
        }

        public string AppDescription(int projectId, string locale)
        {
            throw new System.NotImplementedException();
        }

        public string Status(int projectId, string fileName, string locale)
        {
            throw new System.NotImplementedException();
        }
    }
}