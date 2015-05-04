namespace OneSkyDotNet
{
    using System;

    public class PlatformPlain : IPlatformPlain
    {
        public IPlatformPlainProjectGroup ProjectGroup { get; private set; }

        public IPlatformPlainProject Project { get; private set; }

        public IPlatformPlainProjectType ProjectType { get; private set; }

        public IPlatformPlainLocale Locale { get; private set; }

        public IPlatformPlainFile File { get; private set; }

        public IPlatformPlainTranslation Translation { get; private set; }

        public IPlatformPlainQuotation Quotation { get; private set; }

        public IPlatformPlainImportTask ImportTask { get; private set; }

        public IPlatformPlainScreenshot Screenshot { get; private set; }

        public IPlatformPlainOrder Order { get; private set; }

        internal PlatformPlain(OneSky oneSky)
        {
            this.Locale = new PlatformPlainLocale(oneSky);
            this.ProjectType = new PlatformPlainProjectType(oneSky);
            this.ProjectGroup = new PlatformPlainProjectGroup(oneSky);
            this.Project = new PlatformPlainProject(oneSky);
            this.Quotation = new PlatformPlainQuotation(oneSky);
            this.Order = new PlatformPlainOrder(oneSky);
            this.File = new PlatformPlainFile(oneSky);
            this.ImportTask = new PlatformPlainImportTask(oneSky);
            this.Translation = new PlatformPlainTranslation(oneSky);
            this.Screenshot = new PlatformPlainScreenshot(oneSky);
        }
    }
}