namespace OneSky.CSharp
{
    public interface IPluginOrder
    {
        IOneSkyResponse GetOrders(int projectId, int page = 1, int perPage = 15);

        IOneSkyResponse GetOrder(int projectId, int orderId);

        IOneSkyResponse GetOrderItems(int projectId, int orderId);

        IOneSkyResponse GetOrderMessages(int projectId, int orderId, int page = 1, int perPage = 15);

        IOneSkyResponse PostOrders(
            int projectId,
            string fromLocale,
            string toLocales,
            string items,
            string tone = null,
            string note = null,
            bool isIncludingReview = false,
            string specialization = "general");
    }
}