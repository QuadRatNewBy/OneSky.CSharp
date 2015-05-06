namespace OneSkyDotNet
{
    public class PluginProject : IPluginProject
    {
        private const string GetProjectsAddress = "https://plugin.api.onesky.io/1/projects";
        private const string PostProjectAddress = "https://plugin.api.onesky.io/1/projects";

        private const string GetProjectsPlatformParam = "platform";
        private const string PostProjectPlatformBody = "platform";
        private const string PostProjectNameBody = "name";
        private const string PostProjectLocaleBody = "locale";

        private OneSky oneSky;

        internal PluginProject(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public string GetProjects(string platform = "magento")
        {
            return this.oneSky.CreateRequest(GetProjectsAddress).Parameter(GetProjectsPlatformParam, platform).Get();
        }

        public string PostProject(string name, string platform = "magento", string locale = null)
        {
            return
                this.oneSky.CreateRequest(PostProjectAddress)
                    .Body(PostProjectNameBody, name)
                    .Body(PostProjectPlatformBody, platform)
                    .Body(PostProjectLocaleBody, locale, locale != null)
                    .Post();
        }
    }
}