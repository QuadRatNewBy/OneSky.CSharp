namespace OneSkyDotNet
{
    using System;

    public class PlatformPlain : IPlatformPlain
    {
        public IPlatformPlainProjectGroup ProjectGroup
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPlatformPlainProject Project
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPlatformPlainProjectType ProjectType { get; private set; }

        public IPlatformPlainLocale Locale { get; private set; }

        public IPlatformPlainFile File
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPlatformPlainTranslation Translation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPlatformPlainQuotation Quotation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPlatformPlainImportTask ImportTask
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPlatformPlainScreenshot Screenshot
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPlatformPlainOrder Order
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        internal PlatformPlain(OneSky oneSky)
        {
            this.Locale = new PlatformPlainLocale(oneSky);
            this.ProjectType = new PlatformPlainProjectType(oneSky);
        }
    }
}