namespace OneSky.CSharp
{
    /// <summary>
    /// Plugin API access object.
    /// </summary>
    internal class Plugin : IPlugin
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plugin"/> class.
        /// </summary>
        /// <param name="oneSky">
        /// The OneSky helper.
        /// </param>
        internal Plugin(OneSkyHelper oneSky)
        {
            this.Locale = new PluginLocale(oneSky);
            this.Specialization = new PluginSpecialization(oneSky);
            this.Project = new PluginProject(oneSky);
            this.Item = new PluginItem(oneSky);
            this.Quotation = new PluginQuotation(oneSky);
            this.Order = new PluginOrder(oneSky);
            this.Account = new PluginAccount(oneSky, OneSkyClient.Anonymous);
            this.LanguagePair = new PluginLanguagePair(oneSky);
        }

        /// <summary>
        /// Provides access Account resources.
        /// </summary>
        public IPluginAccount Account { get; private set; }

        /// <summary>
        /// Provides access Locale resources.
        /// </summary>
        public IPluginLocale Locale { get; private set; }

        /// <summary>
        /// Provides access Specialization resources.
        /// </summary>
        public IPluginSpecialization Specialization { get; private set; }

        /// <summary>
        /// Provides access Project resources.
        /// </summary>
        public IPluginProject Project { get; private set; }

        /// <summary>
        /// Provides access Item resources.
        /// </summary>
        public IPluginItem Item { get; private set; }

        /// <summary>
        /// Provides access Order resources.
        /// </summary>
        public IPluginOrder Order { get; private set; }

        /// <summary>
        /// Provides access Quotation resources.
        /// </summary>
        public IPluginQuotation Quotation { get; private set; }

        /// <summary>
        /// Provides access Language Pair resources.
        /// </summary>
        public IPluginLanguagePair LanguagePair { get; private set; }
    }
}