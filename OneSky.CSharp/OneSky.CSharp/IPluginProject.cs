namespace OneSky.CSharp
{
    public interface IPluginProject
    {
        IOneSkyResponse GetProjects(string platform = "magento");

        IOneSkyResponse PostProject(string name, string platform = "magento", string locale = null);
    }
}