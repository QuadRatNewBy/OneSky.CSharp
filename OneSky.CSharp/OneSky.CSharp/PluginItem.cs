namespace OneSky.CSharp
{
    internal class PluginItem : IPluginItem
    {
        private const string GetItemsAddress = "https://plugin.api.onesky.io/1/projects/{project_id}/items";

        private const string GetItemAddress = "https://api.plugin.onesky.io/1/projects/{project_id}/items/{item_id}";

        private const string DeleteItemAddress = "https://api.plugin.onesky.io/1/projects/{project_id}/items/{item_id}";

        private const string GetItemsLocaleParam = "locale";

        private const string GetItemsPageParam = "page";

        private const string GetItemsPerPageParam = "per_page";

        private const string ProjectIdPlaceholder = "project_id";

        private const string ItemIdPlaceholder = "item_id";

        private OneSkyHelper oneSky;

        internal PluginItem(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse GetItems(int projectId, string locale = null, int page = 1, int perPage = 15)
        {
            return
                this.oneSky.CreateRequest(GetItemsAddress)
                    .Placeholder(ProjectIdPlaceholder, projectId)
                    .Parameter(GetItemsPageParam, page)
                    .Parameter(GetItemsPerPageParam, perPage)
                    .Parameter(GetItemsLocaleParam, locale, locale != null)
                    .Get();
        }

        public IOneSkyResponse GetItem(int projectId, int itemId)
        {
            return
                this.oneSky.CreateRequest(GetItemAddress)
                    .Placeholder(ProjectIdPlaceholder, projectId)
                    .Placeholder(ItemIdPlaceholder, itemId)
                    .Get();
        }

        public IOneSkyResponse DeleteItem(int projectId, int itemId)
        {
            return
                this.oneSky.CreateRequest(DeleteItemAddress)
                    .Placeholder(ProjectIdPlaceholder, projectId)
                    .Placeholder(ItemIdPlaceholder, itemId)
                    .Delete();
        }
    }
}