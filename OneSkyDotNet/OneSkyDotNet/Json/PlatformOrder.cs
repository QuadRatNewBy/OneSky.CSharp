namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    internal class PlatformOrder : IPlatformOrder
    {
        private OneSkyDotNet.IPlatformOrder order;

        public PlatformOrder(OneSkyDotNet.IPlatformOrder order)
        {
            this.order = order;
        }

        public IOneSkyResponse<IMetaList, IOrderPlatformEntry> List(int projectId, int page = 1, int perPage = 50, string fileName = null)
        {
            var plain = this.order.List(projectId, page, perPage, fileName);
            return JsonHelper.PlatformCompose<IMetaList, IOrderPlatformEntry, MetaList, OrderPlatformEntry>(plain);
        }

        public IOneSkyResponse<IMeta, IOrderPlatformDetails> Show(int projectId, int orderId)
        {
            var plain = this.order.Show(projectId, orderId);
            return JsonHelper.PlatformCompose<IMeta, IOrderPlatformDetails, Meta, OrderPlatformDetails>(plain);
        }

        public IOneSkyResponse<IMeta, IOrderPlatformNew> Create(
            int projectId,
            IEnumerable<string> files,
            string toLocale,
            string orderType = "translate-only",
            bool isIncludingNotTranslated = true,
            bool isIncludingNotApproved = true,
            bool isIncludingOutdated = true,
            string translatorType = "preferred",
            string tone = "not-specified",
            string specialization = "general",
            string note = null)
        {
            var plain = this.order.Create(
                projectId,
                files,
                toLocale,
                orderType,
                isIncludingNotTranslated,
                isIncludingNotApproved,
                isIncludingOutdated,
                translatorType,
                tone,
                specialization,
                note);
            return JsonHelper.PlatformCompose<IMeta, IOrderPlatformNew, Meta, OrderPlatformNew>(plain);
        }
    }
}