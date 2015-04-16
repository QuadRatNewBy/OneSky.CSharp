namespace OneSkyDotNet
{
    using System;

    public static class OneSkyClient
    {
        public static IOneSkyPlainClient CreatePlainClient(string publicKey, string secretKey)
        {
            var oneSky = new OneSky(publicKey, secretKey);
            return new OneSkyPlainClient(oneSky);
        }
    }
}