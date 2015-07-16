namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    public interface IPluginOrder
    {
        IOneSkyResponse<IMeta, IEnumerable<IOrderPlugin>> GetOrders(int projectId, int page = 1, int perPage = 15);

        IOneSkyResponse<IMeta, IOrderPluginDetails> GetOrder(int projectId, int orderId);

        IOneSkyResponse<IMeta, IEnumerable<IItemDetails>> GetOrderItems(int projectId, int orderId);

        IOneSkyResponse<IMeta, IEnumerable<IMessage>> GetOrderMessages(int projectId, int orderId, int page = 1, int perPage = 15);

        IOneSkyResponse<IMeta, IOrderPluginNew> PostOrders(
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