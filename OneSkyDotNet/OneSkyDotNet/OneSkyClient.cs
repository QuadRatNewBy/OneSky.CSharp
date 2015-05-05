namespace OneSkyDotNet
{
    public class OneSkyClient : IOneSkyClient
    {
        public static IOneSkyClient CreateClient(string publicKey, string secretKey)
        {
            var oneSky = new OneSky(publicKey, secretKey);
            return new OneSkyClient(oneSky);
        }

        public IPlatform Platform { get; private set; }

        internal OneSkyClient(OneSky oneSky)
        {
            this.Platform = new Platform(oneSky);
        }
    }
}