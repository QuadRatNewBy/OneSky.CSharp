namespace OneSkyDotNet.Json
{
    public interface IPlatform
    {
        IPlatformLocale Locale { get; }

        IPlatformProjectType ProjectType { get; }

        IPlatformProjectGroup ProjectGroup { get; }

        IPlatformProject Project { get; }

        IPlatformFile File { get; }

        IPlatformQuotation Quotation { get; }

        IPlatformImportTask ImportTask { get; }

        IPlatformTranslation Translation { get; }

        IPlatformOrder Order { get; }
    }
}