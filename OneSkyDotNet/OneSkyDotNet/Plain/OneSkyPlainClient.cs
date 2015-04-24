namespace OneSkyDotNet
{
    public class OneSkyPlainClient : IOneSkyPlainClient
    {
        public IPlatformPlain Platform { get; private set; }

        internal OneSkyPlainClient(OneSky oneSky)
        {
            this.Platform = new PlatformPlain(oneSky);
        }
    }
}