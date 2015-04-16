namespace OneSkyDotNet
{
    public interface IPlatformPlain
    {
        IPlatformPlainProjectGroup ProjectGroup { get; }

        IPlatformPlainProject Project { get; }

        IPlatformPlainProjectType ProjectType { get; }

        IPlatformPlainLocale Locale { get; }

        IPlatformPlainFile File { get; }

        IPlatformPlainTranslation Translation { get; }

        IPlatformPlainQuotation Quotation { get; }

        IPlatformPlainImportTask ImportTask { get; }

        IPlatformPlainScreenshot Screenshot { get; }

        IPlatformPlainOrder Order { get; }
    }
}