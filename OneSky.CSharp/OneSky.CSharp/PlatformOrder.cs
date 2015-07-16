namespace OneSkyDotNet
{
    using System.Collections.Generic;

    internal class PlatformOrder : IPlatformOrder
    {
        private const string OrderListAddress = "https://platform.api.onesky.io/1/projects/{project_id}/orders";
        private const string OrderShowAddress = "https://platform.api.onesky.io/1/projects/{project_id}/orders/{order_id}";
        private const string OrderCreateAddress = "https://platform.api.onesky.io/1/projects/{project_id}/orders";
        
        private const string OrderListPageParam = "page";
        private const string OrderListPerPageParam = "per_page";
        private const string OrderListFileNameParam = "file_name";

        private const string OrderShowFilesBody = "files";
        private const string OrderShowToLocaleBody = "to_locale";
        private const string OrderShowOrderTypeBody = "order_type";
        private const string OrderShowIsIncludingNotTranslatedBody = "is_including_not_translated";
        private const string OrderShowIsIncludingNotApprovedBody = "is_including_not_approved";
        private const string OrderShowIsIncludingOutdatedBody = "is_including_outdated";
        private const string OrderShowTranslatorTypeBody = "translator_type";
        private const string OrderShowToneBody = "tone";
        private const string OrderShowSpecializationBody = "specialization";
        private const string OrderShowNoteBody = "note";

        private const string OrderIdPlacehoder = "order_id";
        private const string ProjectIdPlacehoder = "project_id";

        private OneSky oneSky;

        internal PlatformOrder(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse List(int projectId, int page = 1, int perPage = 50, string fileName = null)
        {
            return
                this.oneSky.CreateRequest(OrderListAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Parameter(OrderListPageParam, page)
                    .Parameter(OrderListPerPageParam, perPage)
                    .Parameter(OrderListFileNameParam, fileName, fileName != null)
                    .Get();
        }

        public IOneSkyResponse Show(int projectId, int orderId)
        {
            return
                this.oneSky.CreateRequest(OrderShowAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Placeholder(OrderIdPlacehoder, orderId)
                    .Get();
        }

        public IOneSkyResponse Create(
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
            // `body` or `parameter`?
            return
                this.oneSky.CreateRequest(OrderCreateAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Parameter(OrderShowFilesBody, files)
                    .Parameter(OrderShowToLocaleBody, toLocale)
                    .Body(OrderShowOrderTypeBody, orderType)
                    .Body(OrderShowIsIncludingNotTranslatedBody, isIncludingNotTranslated)
                    .Body(OrderShowIsIncludingNotApprovedBody, isIncludingNotApproved)
                    .Body(OrderShowIsIncludingOutdatedBody, isIncludingOutdated)
                    .Body(OrderShowTranslatorTypeBody, translatorType)
                    .Body(OrderShowToneBody, tone)
                    .Body(OrderShowSpecializationBody, specialization)
                    .Body(OrderShowNoteBody, note, note != null)
                    .Post();
        }
    }
}