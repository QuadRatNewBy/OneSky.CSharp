namespace OneSky.CSharp
{
    /// <summary>
    /// Platform API access object.
    /// </summary>
    internal class Platform : IPlatform
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Platform"/> class.
        /// </summary>
        /// <param name="oneSky">
        /// OneSky helper.
        /// </param>
        internal Platform(OneSkyHelper oneSky)
        {
            this.Locale = new PlatformLocale(oneSky);
            this.ProjectType = new PlatformProjectType(oneSky);
            this.ProjectGroup = new PlatformProjectGroup(oneSky);
            this.Project = new PlatformProject(oneSky);
            this.Quotation = new PlatformQuotation(oneSky);
            this.Order = new PlatformOrder(oneSky);
            this.File = new PlatformFile(oneSky);
            this.ImportTask = new PlatformImportTask(oneSky);
            this.Translation = new PlatformTranslation(oneSky);
            this.Screenshot = new PlatformScreenshot(oneSky);
        }

        /// <summary>
        /// Provides access Project Group resources.
        /// </summary>
        public IPlatformProjectGroup ProjectGroup { get; private set; }

        /// <summary>
        /// Provides access Project resources.
        /// </summary>
        public IPlatformProject Project { get; private set; }

        /// <summary>
        /// Provides access Project Type resources.
        /// </summary>
        public IPlatformProjectType ProjectType { get; private set; }

        /// <summary>
        /// Provides access Locale resources.
        /// </summary>
        public IPlatformLocale Locale { get; private set; }

        /// <summary>
        /// Provides access File resources.
        /// </summary>
        public IPlatformFile File { get; private set; }

        /// <summary>
        /// Provides access Translation resources.
        /// </summary>
        public IPlatformTranslation Translation { get; private set; }

        /// <summary>
        /// Provides access Quotation resources.
        /// </summary>
        public IPlatformQuotation Quotation { get; private set; }

        /// <summary>
        /// Provides access Import Task resources.
        /// </summary>
        public IPlatformImportTask ImportTask { get; private set; }

        /// <summary>
        /// Provides access Screenshot resources.
        /// </summary>
        public IPlatformScreenshot Screenshot { get; private set; }

        /// <summary>
        /// Provides access Order resources.
        /// </summary>
        public IPlatformOrder Order { get; private set; }
    }
}