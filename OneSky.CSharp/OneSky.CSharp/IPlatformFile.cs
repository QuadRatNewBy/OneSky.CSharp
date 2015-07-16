namespace OneSky.CSharp
{
    public interface IPlatformFile
    {
        IOneSkyResponse List(int projectId, int page = 1, int perPage = 50);

        IOneSkyResponse Upload(
            int projectId,
            string file,
            string fileFormat,
            string locale = null,
            bool isKeepingAllStrings = true);

        IOneSkyResponse Delete(int projectId, string fileName);
    }
}