namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    internal class PluginItem : IPluginItem
    {
        private CSharp.IPluginItem item;

        public PluginItem(CSharp.IPluginItem item)
        {
            this.item = item;
        }

        public IOneSkyResponse<IMeta, IEnumerable<IItemEntry>> GetItems(int projectId, string locale = null, int page = 1, int perPage = 15)
        {
            var plain = this.item.GetItems(projectId, locale, page, perPage);
            var tuple = JsonHelper.PluginDeserialize(plain, new { items = new List<ItemEntry>() }, x => x.items);
            return new OneSkyResponse<IMeta, IEnumerable<IItemEntry>>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }

        public IOneSkyResponse<IMeta, IItemDetails> GetItem(int projectId, int itemId)
        {
            var plain = this.item.GetItem(projectId, itemId);
            var tuple = JsonHelper.PluginDeserialize(plain, new { item = new ItemDetails() }, x => x.item);
            return new OneSkyResponse<IMeta, IItemDetails>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }

        public IOneSkyResponse<IMeta, INull> DeleteItem(int projectId, int itemId)
        {
            var plain = this.item.DeleteItem(projectId, itemId);
            var tuple = JsonHelper.PluginDeserialize(plain, new Null(), x => x);
            return new OneSkyResponse<IMeta, INull>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }
    }
}