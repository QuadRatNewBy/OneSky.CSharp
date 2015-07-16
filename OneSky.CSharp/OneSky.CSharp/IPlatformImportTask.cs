namespace OneSkyDotNet
{
    public interface IPlatformImportTask
    {

        IOneSkyResponse List(int projectId, int page = 1, int perPage = 50, string status = "all");

        IOneSkyResponse Show(int projectId, int importTaskId);
    }
}