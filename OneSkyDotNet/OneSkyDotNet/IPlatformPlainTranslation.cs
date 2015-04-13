namespace OneSkyDotNet
{
    public interface IPlatformPlainTranslation
    {
        string Export(int projectId, string locale, string sourceFileName, string exportFileName = null);

        string ExportMultilingualFile(int projectId, string sourceFileName, string exportFileName = null, string fileFormat = null);

        string AppDescription(int projectId, string locale);

        string Status(int projectId, string fileName, string locale);
    }
}