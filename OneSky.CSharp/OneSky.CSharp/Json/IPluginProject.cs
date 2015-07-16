namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    public interface IPluginProject
    {
        IOneSkyResponse<IMeta, IEnumerable<IProjectPlugin>> GetProjects(string platform = "magento");

        IOneSkyResponse<IMeta, IProjectPlugin> PostProject(string name, string platform = "magento", string locale = null);
    }
}
