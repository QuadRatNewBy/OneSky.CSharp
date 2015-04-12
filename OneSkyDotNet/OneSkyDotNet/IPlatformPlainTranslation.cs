namespace OneSkyDotNet
{
    public interface IPlatformPlainTranslation
    {
        string Export(string locale, string sourceFileName, string exportFileName = null);

        string ExportMultilingualFile(string sourceFileName, string exportFileName = null, string fileFormat = null);

        string AppDescription(string locale);

        string Status(string fileName, string locale);
    }
}