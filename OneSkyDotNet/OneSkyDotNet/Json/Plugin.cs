namespace OneSkyDotNet.Json
{
    internal class Plugin : IPlugin
    {
        public IPluginLocale Locale { get; private set; }

        internal Plugin(OneSkyDotNet.IPlugin plugin)
        {
            this.Locale = new PluginLocale(plugin.Locale);
        }
    }
}