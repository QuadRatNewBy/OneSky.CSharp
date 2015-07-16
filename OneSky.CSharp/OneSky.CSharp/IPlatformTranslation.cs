namespace OneSkyDotNet
{
    public interface IPlatformTranslation
    {
        IOneSkyResponse Export(int projectId, string locale, string sourceFileName, string exportFileName = null);

        IOneSkyResponse ExportMultilingualFile(int projectId, string sourceFileName, string exportFileName = null, string fileFormat = null);

        IOneSkyResponse AppDescription(int projectId, string locale);

        IOneSkyResponse Status(int projectId, string fileName, string locale);
    }
}