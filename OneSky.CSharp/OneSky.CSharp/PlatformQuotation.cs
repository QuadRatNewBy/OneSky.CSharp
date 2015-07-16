namespace OneSkyDotNet
{
    using System.Collections.Generic;

    internal class PlatformQuotation : IPlatformQuotation
    {
        private const string QuotationShowAddress = "https://platform.api.onesky.io/1/projects/{project_id}/quotations";

        private const string ProjectIdPlacehoder = "project_id";

        private const string QuotationShowFilesPrarm = "files";
        private const string QuotationShowToLocalePrarm = "to_locale";
        private const string QuotationShowIsIncludingNotTranslatedPrarm = "is_including_not_translated";
        private const string QuotationShowIsIncludingNotApprovedPrarm = "is_including_not_approved";
        private const string QuotationShowIsIncludingOutdatedPrarm = "is_including_outdated";
        private const string QuotationShowSpecializationPrarm = "specialization";

        private OneSky oneSky;

        internal PlatformQuotation(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse Show(
            int projectId,
            IEnumerable<string> files,
            string toLocale,
            bool isIncludingNotTranslated = true,
            bool isIncludingNotApproved = true,
            bool isIncludingOutdated = true,
            string specialization = "general")
        {
            return
                this.oneSky.CreateRequest(QuotationShowAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Parameter(QuotationShowFilesPrarm, files)
                    .Parameter(QuotationShowToLocalePrarm, toLocale)
                    .Parameter(QuotationShowIsIncludingNotTranslatedPrarm, isIncludingNotTranslated)
                    .Parameter(QuotationShowIsIncludingNotApprovedPrarm, isIncludingNotApproved)
                    .Parameter(QuotationShowIsIncludingOutdatedPrarm, isIncludingOutdated)
                    .Parameter(QuotationShowSpecializationPrarm, specialization)
                    .Get();
        }
    }
}