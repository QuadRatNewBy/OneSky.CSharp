namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    internal class PlatformQuotation : IPlatformQuotation
    {
        private OneSkyDotNet.IPlatformQuotation quotation;

        public PlatformQuotation(OneSkyDotNet.IPlatformQuotation quotation)
        {
            this.quotation = quotation;
        }

        public IOneSkyResponse<IMeta, IQuotationPlatform> Show(
            int projectId,
            IEnumerable<string> files,
            string toLocale,
            bool isIncludingNotTranslated = true,
            bool isIncludingNotApproved = true,
            bool isIncludingOutdated = true,
            string specialization = "general")
        {
            var plain = this.quotation.Show(
                projectId,
                files,
                toLocale,
                isIncludingNotTranslated,
                isIncludingNotApproved,
                isIncludingOutdated,
                specialization);
            return JsonHelper.PlatformCompose<IMeta, IQuotationPlatform, Meta, QuotationPlatform>(plain);
        }
    }
}