namespace OneSkyDotNet
{
    public interface IPluginItem
    {
        string GetItems(int projectId, string locale = null, int page = 1, int perPage = 15);

        string GetItem(int projectId, int itemId);

        string DeleteItem(int projectId, int itemId);
    }
}