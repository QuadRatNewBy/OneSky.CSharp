namespace OneSkyDotNet
{
    public interface IPlatformPlainFile
    {

        string List(int projectId, int page = 1, int perPage = 50);

        string Upload(
            int projectId,
            string file,
            string fileFormat,
            string locale = null,
            bool isKeepingAllStrings = true);

        string Delete(int projectId, string fileName);
    }
}