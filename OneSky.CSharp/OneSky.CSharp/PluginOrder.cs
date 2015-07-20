namespace OneSky.CSharp
{
    internal class PluginOrder : IPluginOrder
    {
        private const string GetOrdersAddress = "https://plugin.api.onesky.io/1/projects/{project_id}/orders";
        private const string GetOrderAddress = "https://plugin.api.onesky.io/1/projects/{project_id}/orders/{order_id}";
        private const string GetOrderItemsAddress = "https://plugin.api.onesky.io/1/projects/{project_id}/orders/{order_id}/items";
        private const string GetOrderMessagesAddress = "https://plugin.api.onesky.io/1/projects/{project_id}/orders/{order_id}/messages";
        private const string PostOrdersAddress = "https://plugin.api.onesky.io/1/projects/{project_id}/orders";

        private const string GetOrdersPageParam = "page";
        private const string GetOrdersPerPageParam = "per_page";

        private const string GetOrderMessagesPageParam = "page";
        private const string GetOrderMessagesPerPageParam = "per_page";

        private const string PostOrdersFromLocaleBody = "from_locale";
        private const string PostOrdersToLocalesBody = "to_locales";
        private const string PostOrdersItemsBody = "items";
        private const string PostOrdersToneBody = "tone";
        private const string PostOrdersNoteBody = "note";
        private const string PostOrdersIsIncludingReviewBody = "is_including_review";
        private const string PostOrdersSpecializationBody = "specialization";

        private const string ProjectIdPlacehoder = "project_id";
        private const string OrderIdPlacehoder = "order_id";

        private OneSkyHelper oneSky;

        internal PluginOrder(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse GetOrders(int projectId, int page = 1, int perPage = 15)
        {
            return
                this.oneSky.CreateRequest(GetOrdersAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Parameter(GetOrdersPageParam, page)
                    .Parameter(GetOrdersPerPageParam, perPage)
                    .Get();
        }

        public IOneSkyResponse GetOrder(int projectId, int orderId)
        {
            return
                this.oneSky.CreateRequest(GetOrderAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Placeholder(OrderIdPlacehoder, orderId)
                    .Get();
        }

        public IOneSkyResponse GetOrderItems(int projectId, int orderId)
        {
            return
                this.oneSky.CreateRequest(GetOrderItemsAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Placeholder(OrderIdPlacehoder, orderId)
                    .Get();
        }

        public IOneSkyResponse GetOrderMessages(int projectId, int orderId, int page = 1, int perPage = 15)
        {
            return
                this.oneSky.CreateRequest(GetOrderMessagesAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Placeholder(OrderIdPlacehoder, orderId)
                    .Parameter(GetOrderMessagesPageParam, page)
                    .Parameter(GetOrderMessagesPerPageParam, perPage)
                    .Get();
        }

        public IOneSkyResponse PostOrders(
            int projectId,
            string fromLocale,
            string toLocales,
            string items,
            string tone = null,
            string note = null,
            bool isIncludingReview = false,
            string specialization = "general")
        {
            return
                this.oneSky.CreateRequest(PostOrdersAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Body(PostOrdersFromLocaleBody, fromLocale)
                    .Body(PostOrdersToLocalesBody, toLocales)
                    .Body(PostOrdersItemsBody, items)
                    .Body(PostOrdersToneBody, tone, tone != null)
                    .Body(PostOrdersNoteBody, note, note != null)
                    .Body(PostOrdersIsIncludingReviewBody, isIncludingReview)
                    .Body(PostOrdersSpecializationBody, specialization)
                    .Post();
        }
    }
}