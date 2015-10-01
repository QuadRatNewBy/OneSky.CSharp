namespace OneSky.CSharp.Json
{
    /// <summary>
    /// Platform API access interface.
    /// </summary>
    public interface IPlatform
    {
        /// <summary>
        /// Provides access Locale resources.
        /// </summary>
        IPlatformLocale Locale { get; }

        /// <summary>
        /// Provides access Project Type resources.
        /// </summary>
        IPlatformProjectType ProjectType { get; }

        /// <summary>
        /// Provides access Project Group resources.
        /// </summary>
        IPlatformProjectGroup ProjectGroup { get; }

        /// <summary>
        /// Provides access Project resources.
        /// </summary>
        IPlatformProject Project { get; }

        /// <summary>
        /// Provides access File resources.
        /// </summary>
        IPlatformFile File { get; }

        /// <summary>
        /// Provides access Quotation resources.
        /// </summary>
        IPlatformQuotation Quotation { get; }

        /// <summary>
        /// Provides access Import Task resources.
        /// </summary>
        IPlatformImportTask ImportTask { get; }

        /// <summary>
        /// Provides access Translation resources.
        /// </summary>
        IPlatformTranslation Translation { get; }

        /// <summary>
        /// Provides access Order resources.
        /// </summary>
        IPlatformOrder Order { get; }

        /// <summary>
        /// Provides access Screenshot resources.
        /// </summary>
        IPlatformScreenshot Screenshot { get; }
    }
}