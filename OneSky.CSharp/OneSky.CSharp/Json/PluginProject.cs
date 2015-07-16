namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    internal class PluginProject : IPluginProject
    {
        private OneSkyDotNet.IPluginProject project;

        internal PluginProject(OneSkyDotNet.IPluginProject project)
        {
            this.project = project;
        }

        public IOneSkyResponse<IMeta, IEnumerable<IProjectPlugin>> GetProjects(string platform = "magento")
        {
            var plain = this.project.GetProjects(platform);
            var tuple = JsonHelper.PluginDeserialize(
                plain,
                new { projects = new List<ProjectPlugin>() },
                d => d.projects);
            return new OneSkyResponse<IMeta, IEnumerable<IProjectPlugin>>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }

        public IOneSkyResponse<IMeta, IProjectPlugin> PostProject(string name, string platform = "magento", string locale = null)
        {
            var plain = this.project.PostProject(name, platform, locale);
            var tuple = JsonHelper.PluginDeserialize(plain, new { project = new ProjectPlugin() }, x => x.project);
            return new OneSkyResponse<IMeta, IProjectPlugin>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }
    }
}
