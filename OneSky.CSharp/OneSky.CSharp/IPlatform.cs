namespace OneSky.CSharp
{
    public interface IPlatform
    {
        IPlatformProjectGroup ProjectGroup { get; }

        IPlatformProject Project { get; }

        IPlatformProjectType ProjectType { get; }

        IPlatformLocale Locale { get; }

        IPlatformFile File { get; }

        IPlatformTranslation Translation { get; }

        IPlatformQuotation Quotation { get; }

        IPlatformImportTask ImportTask { get; }

        IPlatformScreenshot Screenshot { get; }

        IPlatformOrder Order { get; }
    }
}