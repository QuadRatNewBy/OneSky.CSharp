namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    internal class MetaPagedList : MetaList, IMetaPagedList
    {
        [JsonProperty("page_count")]
        protected int pageCount;

        [JsonProperty("next_page")]
        protected string nextPage;

        [JsonProperty("prev_page")]
        protected string previousPage;

        [JsonProperty("first_page")]
        protected string firstPage;

        [JsonProperty("last_page")]
        protected string lastPage;

        public int PageCount
        {
            get
            {
                return this.pageCount;
            }
        }

        public string NextPage
        {
            get
            {
                return this.nextPage;
            }
        }

        public string PreviousPage
        {
            get
            {
                return this.previousPage;
            }
        }

        public string FirstPage
        {
            get
            {
                return this.firstPage;
            }
        }

        public string LastPage
        {
            get
            {
                return this.lastPage;
            }
        }
    }
}