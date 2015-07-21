namespace OneSky.CSharp.Json
{
    internal class OneSkyResponse<TMeta, TData> : IOneSkyResponse<TMeta, TData>
    {
        internal OneSkyResponse(int statusCode, string statusDescription, TMeta meta, TData data)
        {
            this.StatusCode = statusCode;
            this.StatusDescription = statusDescription;
            this.Meta = meta;
            this.Data = data;
        }

        public int StatusCode { get; private set; }

        public string StatusDescription { get; private set; }

        public TMeta Meta { get; private set; }

        public TData Data { get; private set; }
    }
}