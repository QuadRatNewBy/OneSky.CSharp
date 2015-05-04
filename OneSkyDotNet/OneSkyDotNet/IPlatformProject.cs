namespace OneSkyDotNet
{
    public interface IPlatformProject
    {

        string List(int projectGroupId);

        string Show(int projectId);

        string Create(int projectGroupId, string projectType, string name = null, string description = null);

        string Update(int projectId, string name = null, string description = null);

        string Delete(int projectId);

        string Languages(int projectId);
    }
}