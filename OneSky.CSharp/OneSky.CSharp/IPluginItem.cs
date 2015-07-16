namespace OneSky.CSharp
{
    public interface IPluginItem
    {
        IOneSkyResponse GetItems(int projectId, string locale = null, int page = 1, int perPage = 15);

        IOneSkyResponse GetItem(int projectId, int itemId);

        IOneSkyResponse DeleteItem(int projectId, int itemId);
    }
}