namespace OneSky.CSharp
{
    internal class Platform : IPlatform
    {
        public IPlatformProjectGroup ProjectGroup { get; private set; }

        public IPlatformProject Project { get; private set; }

        public IPlatformProjectType ProjectType { get; private set; }

        public IPlatformLocale Locale { get; private set; }

        public IPlatformFile File { get; private set; }

        public IPlatformTranslation Translation { get; private set; }

        public IPlatformQuotation Quotation { get; private set; }

        public IPlatformImportTask ImportTask { get; private set; }

        public IPlatformScreenshot Screenshot { get; private set; }

        public IPlatformOrder Order { get; private set; }

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
    }
}