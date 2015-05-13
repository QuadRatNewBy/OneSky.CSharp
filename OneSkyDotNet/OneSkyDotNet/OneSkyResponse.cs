namespace OneSkyDotNet
{
    internal class OneSkyResponse : IOneSkyResponse
    {
        public int StatusCode { get; internal set; }
        public string StatusDescription { get; internal set; }
        public string Data { get; internal set; }
    }
}
