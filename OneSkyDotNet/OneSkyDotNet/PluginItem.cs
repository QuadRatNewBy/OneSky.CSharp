namespace OneSkyDotNet
{
    internal class PluginItem : IPluginItem
    {
        private const string GetItemsAddress = "https://plugin.api.onesky.io/1/projects/{project_id}/items";
        private const string GetItemAddress = "https://api.plugin.onesky.io/1/projects/{project_id}/items/{item_id}";
        private const string DeleteItemAddress = "https://api.plugin.onesky.io/1/projects/{project_id}/items/{item_id}";

        private const string GetItemsLocaleParam = "locale";
        private const string GetItemsPageParam = "page";
        private const string GetItemsPerPageParam = "per_page";

        private const string ProjectIdPlacehoder = "project_id";
        private const string ItemIdPlacehoder = "item_id";

        private OneSky oneSky;

        internal PluginItem(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public string GetItems(int projectId, string locale = null, int page = 1, int perPage = 15)
        {
            return
                this.oneSky.CreateRequest(GetItemsAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Parameter(GetItemsPageParam, page)
                    .Parameter(GetItemsPerPageParam, perPage)
                    .Parameter(GetItemsLocaleParam, locale, locale != null)
                    .Get();
        }

        public string GetItem(int projectId, int itemId)
        {
            return
                this.oneSky.CreateRequest(GetItemAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Placeholder(ItemIdPlacehoder, itemId)
                    .Get();
        }

        public string DeleteItem(int projectId, int itemId)
        {
            return
                this.oneSky.CreateRequest(DeleteItemAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Placeholder(ItemIdPlacehoder, itemId)
                    .Delete();
        }
    }
}