namespace OneSkyDotNet
{
    public interface IPluginOrder
    {
        string GetOrders(int projectId, int page = 1, int perPage = 15);

        string GetOrder(int projectId, int orderId);

        string GetOrderItems(int projectId, int orderId);

        string GetOrderMessages(int projectId, int orderId, int page = 1, int perPage = 15);

        string PostOrder(
            int projectId,
            string fromLocale,
            string toLocales,
            string items,
            string tone = null,
            string note = null,
            bool isIncludingReview = false,
            string specialization = null);
    }
}