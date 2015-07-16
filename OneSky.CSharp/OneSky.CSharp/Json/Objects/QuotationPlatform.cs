namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class QuotationPlatform : Quotation, IQuotationPlatform
    {
        [JsonProperty("files")]
        private IEnumerable<File> files;

        [JsonProperty("is_including_not_translated")]
        private bool isIncludingNotTranslated;

        [JsonProperty("is_including_not_approved")]
        private bool isIncludingNotApproved;

        [JsonProperty("is_including_outdated")]
        private bool isIncludingOutdated;

        [JsonProperty("specialization")]
        private string specialization;

        [JsonProperty("translation_only")]
        private QuotationDetailsFull translationOnly;

        [JsonProperty("translation_and_review")]
        private QuotationDetailsFull translationAndReview;

        [JsonProperty("review_only")]
        private QuotationDetailsFull reviewOnly;

        public IEnumerable<IFile> Files
        {
            get
            {
                return this.files;
            }
        }

        public bool IsIncludingNotTranslated
        {
            get
            {
                return this.isIncludingNotTranslated;
            }
        }

        public bool IsIncludingNotApproved
        {
            get
            {
                return this.isIncludingNotApproved;
            }
        }

        public bool IsIncludingOutdated
        {
            get
            {
                return this.isIncludingOutdated;
            }
        }

        public string Specialization
        {
            get
            {
                return this.specialization;
            }
        }

        public IQuotationDetailsFull TranslationOnly
        {
            get
            {
                return this.translationOnly;
            }
        }

        public IQuotationDetailsFull TranslationAndReview
        {
            get
            {
                return this.translationAndReview;
            }
        }

        public IQuotationDetailsFull ReviewOnly
        {
            get
            {
                return this.reviewOnly;
            }
        }
    }
}