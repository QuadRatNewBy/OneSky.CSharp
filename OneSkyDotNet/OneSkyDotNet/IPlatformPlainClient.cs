namespace OneSkyDotNet
{
    using System;

    public interface IPlatformPlainClient
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