namespace OneSkyDotNet.Json
{
    public interface IPlatformTranslation
    {
        IOneSkyResponse<IMeta, string> Export(int projectId, string locale, string sourceFileName, string exportFileName = null);

        IOneSkyResponse<IMeta, string> ExportMultilingualFile(int projectId, string sourceFileName, string exportFileName = null, string fileFormat = null);

        IOneSkyResponse<IMeta, IAppDescription> AppDescription(int projectId, string locale);

        IOneSkyResponse<IMeta, ITranslationStatus> Status(int projectId, string fileName, string locale);
    }
}