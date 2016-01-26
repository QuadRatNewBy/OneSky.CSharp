namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;
    using System.Linq;

    using Newtonsoft.Json;

    internal class PluginOrder : IPluginOrder
    {
        private CSharp.IPluginOrder order;

        public PluginOrder(CSharp.IPluginOrder order)
        {
            this.order = order;
        }

        public IOneSkyResponse<IMeta, IEnumerable<IOrderPlugin>> GetOrders(int projectId, int page = 1, int perPage = 15)
        {
            var plain = this.order.GetOrders(projectId, page, perPage);
            var tuple = JsonHelper.PluginDeserialize(plain, new { orders = new List<OrderPlugin>() }, x => x.orders);
            return new OneSkyResponse<IMeta, IEnumerable<IOrderPlugin>>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }

        public IOneSkyResponse<IMeta, IOrderPluginDetails> GetOrder(int projectId, int orderId)
        {
            var plain = this.order.GetOrder(projectId, orderId);
            var tuple = JsonHelper.PluginDeserialize(
                plain,
                new { orders = new List<OrderPluginDetails>() },
                x => x.orders == null ? null : x.orders.FirstOrDefault());
            return new OneSkyResponse<IMeta, IOrderPluginDetails>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }

        public IOneSkyResponse<IMeta, IEnumerable<IItemDetails>> GetOrderItems(int projectId, int orderId)
        {
            var plain = this.order.GetOrderItems(projectId, orderId);
            var tuple = JsonHelper.PluginDeserialize(plain, new { items = new List<ItemDetails>() }, x => x.items);
            return new OneSkyResponse<IMeta, IEnumerable<IItemDetails>>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }

        public IOneSkyResponse<IMeta, IEnumerable<IMessage>> GetOrderMessages(int projectId, int orderId, int page = 1, int perPage = 15)
        {
            var plain = this.order.GetOrderMessages(projectId, orderId, page, perPage);
            var tuple = JsonHelper.PluginDeserialize(plain, new { messages = new List<Message>() }, x => x.messages);
            return new OneSkyResponse<IMeta, IEnumerable<IMessage>>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }

        public IOneSkyResponse<IMeta, IOrderPluginNew> PostOrders(
            int projectId,
            string fromLocale,
            IEnumerable<string> toLocales,
            IDictionary<string, IItem> items,
            string tone = null,
            string note = null,
            bool isIncludingReview = false,
            string specialization = "general")
        {
            var plainItems = JsonConvert.SerializeObject(items.ToDictionary(x => x.Key, x => new Item(x.Value)));
            var plainToLocales = string.Join(",", toLocales);
            var plain = this.order.PostOrders(
                projectId,
                fromLocale,
                plainToLocales,
                plainItems,
                tone,
                note,
                isIncludingReview,
                specialization);
            var tuple = JsonHelper.PluginDeserialize(plain, new { order = new OrderPluginNew() }, x => x.order);
            return new OneSkyResponse<IMeta, IOrderPluginNew>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }
    }
}