namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    internal class PluginOrder : IPluginOrder
    {
        private OneSkyDotNet.IPluginOrder order;

        public PluginOrder(OneSkyDotNet.IPluginOrder order)
        {
            this.order = order;
        }

        public IOneSkyResponse<IMeta, IEnumerable<IOrderPlugin>> GetOrders(int projectId, int page = 1, int perPage = 15)
        {
            throw new System.NotImplementedException();
        }

        public IOneSkyResponse<IMeta, IOrderPluginDetails> GetOrder(int projectId, int orderId)
        {
            throw new System.NotImplementedException();
        }

        public IOneSkyResponse<IMeta, IEnumerable<IItemDetails>> GetOrderItems(int projectId, int orderId)
        {
            throw new System.NotImplementedException();
        }

        public IOneSkyResponse<IMeta, IEnumerable<IMessage>> GetOrderMessages(int projectId, int orderId, int page = 1, int perPage = 15)
        {
            throw new System.NotImplementedException();
        }

        public IOneSkyResponse<IMeta, IOrderPluginNew> PostOrders(
            int projectId,
            string fromLocale,
            string toLocales,
            string items,
            string tone = null,
            string note = null,
            bool isIncludingReview = false,
            string specialization = "general")
        {
            throw new System.NotImplementedException();
        }
    }
}