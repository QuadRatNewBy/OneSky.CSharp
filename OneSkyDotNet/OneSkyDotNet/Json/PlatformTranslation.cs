namespace OneSkyDotNet.Json
{
    internal class PlatformTranslation : IPlatformTranslation
    {
        private OneSkyDotNet.IPlatformTranslation translation;

        public PlatformTranslation(OneSkyDotNet.IPlatformTranslation translation)
        {
            this.translation = translation;
        }

        public IOneSkyResponse<IMeta, string> Export(int projectId, string locale, string sourceFileName, string exportFileName = null)
        {
            var plain = this.translation.Export(projectId, locale, sourceFileName, exportFileName);
            var meta = JsonHelper.PlatformCompose<IMeta, INull, Meta, Null>(plain);
            return new OneSkyResponse<IMeta, string>(
                plain.StatusCode,
                plain.StatusDescription,
                meta.MetaContent,
                meta.MetaContent.Status != 0 ? string.Empty : plain.Content);
        }

        public IOneSkyResponse<IMeta, string> ExportMultilingualFile(
            int projectId,
            string sourceFileName,
            string exportFileName = null,
            string fileFormat = null)
        {
            var plain = this.translation.ExportMultilingualFile(projectId, sourceFileName, exportFileName, fileFormat);
            var meta = JsonHelper.PlatformCompose<IMeta, INull, Meta, Null>(plain);
            return new OneSkyResponse<IMeta, string>(
                plain.StatusCode,
                plain.StatusDescription,
                meta.MetaContent,
                meta.MetaContent.Status != 0 ? string.Empty : plain.Content);
        }

        public IOneSkyResponse<IMeta, IAppDescription> AppDescription(int projectId, string locale)
        {
            throw new System.NotImplementedException();
        }

        public IOneSkyResponse<IMeta, ITranslationStatus> Status(int projectId, string fileName, string locale)
        {
            throw new System.NotImplementedException();
        }
    }
}