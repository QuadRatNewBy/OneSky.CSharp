namespace OneSkyDotNet
{
    public class Plugin : IPlugin
    {
        public IPluginAccount Account { get; private set; }

        public IPluginLocale Locale { get; private set; }

        public IPluginSpecialization Specialization { get; private set; }

        public IPluginProject Project { get; private set; }

        public IPluginItem Item { get; private set; }

        public IPluginOrder Order { get; private set; }

        public IPluginQuotation Quotation { get; private set; }

        internal Plugin(OneSky oneSky)
        {
            this.Locale = new PluginLocale(oneSky);
            this.Specialization = new PluginSpecialization(oneSky);
            this.Project = new PluginProject(oneSky);
            this.Item = new PluginItem(oneSky);
            this.Quotation = new PluginQuotation(oneSky);
            this.Order = new PluginOrder(oneSky);
        }
    }
}