namespace OneSky.CSharp
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    internal class OneSkyHelper
    {
        private const string AuthenticationApiKey = "api_key";

        private const string AuthenticationTimestamp = "timestamp";

        private const string AuthenticationDevHash = "dev_hash";

        private readonly string publicKey;

        private readonly string secretKey;

        public OneSkyHelper(string publicKey, string secretKey)
        {
            this.publicKey = publicKey;
            this.secretKey = secretKey;
        }

        private int Timestamp
        {
            get
            {
                var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                var diff = DateTime.UtcNow - origin;
                return (int)Math.Floor(diff.TotalSeconds);
            }
        }

        public int RequestCount { get; private set; }

        private string GetDevHash(int timestamp)
        {
            var md5 = MD5.Create();
            var sb = new StringBuilder();

            var input = timestamp + this.secretKey;
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hash = md5.ComputeHash(inputBytes);

            foreach (var b in hash)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        internal IOneSkyRequest CreateRequest(string url)
        {
            var timestamp = this.Timestamp;
            var devHash = this.GetDevHash(timestamp);

            this.RequestCount++;

            return
                (new OneSkyRequest(url)).Parameter(AuthenticationApiKey, this.publicKey)
                    .Parameter(AuthenticationTimestamp, timestamp)
                    .Parameter(AuthenticationDevHash, devHash);
        }

        internal static OneSkyRequest CreateAnonymousRequest(string url)
        {
            return new OneSkyRequest(url);
        }
    }
}