namespace OneSkyDotNet.Json
{
    internal class OneSkyResponse<TMeta, TData> : IOneSkyResponse<TMeta, TData>
    {
        internal OneSkyResponse(int statusCode, string statusDescription, TMeta metaContent, TData dataContent)
        {
            this.StatusCode = statusCode;
            this.StatusDescription = statusDescription;
            this.MetaContent = metaContent;
            this.DataContent = dataContent;
        }

        public int StatusCode { get; private set; }

        public string StatusDescription { get; private set; }

        public TMeta MetaContent { get; private set; }

        public TData DataContent { get; private set; }
    }
}