namespace OneSkyDotNet
{
    public interface IPlatformProject
    {
        IOneSkyResponse List(int projectGroupId);

        IOneSkyResponse Show(int projectId);

        IOneSkyResponse Create(int projectGroupId, string projectType, string name = null, string description = null);

        IOneSkyResponse Update(int projectId, string name = null, string description = null);

        IOneSkyResponse Delete(int projectId);

        IOneSkyResponse Languages(int projectId);
    }
}