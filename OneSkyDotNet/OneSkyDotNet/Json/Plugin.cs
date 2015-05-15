namespace OneSkyDotNet.Json
{
    internal class Plugin : IPlugin
    {
        public IPluginLocale Locale { get; private set; }

        public IPluginSpecialization Specialization { get; private set; }

        public IPluginProject Project { get; private set; }

        internal Plugin(OneSkyDotNet.IPlugin plugin)
        {
            this.Locale = new PluginLocale(plugin.Locale);
            this.Specialization = new PluginSpecialization(plugin.Specialization);
            this.Project = new PluginProject(plugin.Project);
        }
    }
}