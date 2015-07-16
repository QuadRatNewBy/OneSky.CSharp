namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    public interface IPluginItem
    {
        IOneSkyResponse<IMeta, IEnumerable<IItemEntry>> GetItems(int projectId, string locale = null, int page = 1, int perPage = 15);

        IOneSkyResponse<IMeta, IItemDetails> GetItem(int projectId, int itemId);

        IOneSkyResponse<IMeta, INull> DeleteItem(int projectId, int itemId); 
    }
}