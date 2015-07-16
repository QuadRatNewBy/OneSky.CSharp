namespace OneSkyDotNet
{
    public interface IPlatformProjectGroup
    {
        IOneSkyResponse List(int page = 1, int perPage = 50);

        IOneSkyResponse Show(int projectGroupId);

        IOneSkyResponse Create(string name, string locale = "en");

        IOneSkyResponse Delete(int projectGroupId);

        IOneSkyResponse Languages(int projectGroupId);
    }
}