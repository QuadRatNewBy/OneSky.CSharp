#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class MetaPagedList : MetaList, IMetaPagedList
    {
        [JsonProperty("page_count")]
        private int pageCount;

        [JsonProperty("next_page")]
        private string nextPage;

        [JsonProperty("prev_page")]
        private string previousPage;

        [JsonProperty("first_page")]
        private string firstPage;

        [JsonProperty("last_page")]
        private string lastPage;

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