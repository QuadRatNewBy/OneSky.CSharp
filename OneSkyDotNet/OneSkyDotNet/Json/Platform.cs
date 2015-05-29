namespace OneSkyDotNet.Json
{
    internal class Platform : IPlatform
    {
        public IPlatformLocale Locale { get; private set; }

        public IPlatformProjectType ProjectType { get; private set; }

        public IPlatformProjectGroup ProjectGroup { get; private set; }

        public IPlatformProject Project { get; private set; }

        public IPlatformFile File { get; private set; }

        public IPlatformQuotation Quotation { get; private set; }

        public IPlatformImportTask ImportTask { get; private set; }

        public IPlatformTranslation Translation { get; private set; }

        internal Platform(OneSkyDotNet.IPlatform platform)
        {
            this.Locale = new PlatformLocale(platform.Locale);
            this.ProjectType = new PlatformProjectType(platform.ProjectType);
            this.ProjectGroup = new PlatformProjectGroup(platform.ProjectGroup);
            this.Project = new PlatformProject(platform.Project);
            this.File = new PlatformFile(platform.File);
            this.Quotation = new PlatformQuotation(platform.Quotation);
            this.ImportTask = new PlatformImportTask(platform.ImportTask);
            this.Translation = new PlatformTranslation(platform.Translation);
        }
    }
}