namespace OneSkyDotNet
{
    public interface IPluginProject
    {
        string GetProjects(string platform = "magento");

        string PostProject(string name, string platform = "magento", string locale = null);
    }
}