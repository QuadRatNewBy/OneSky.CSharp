namespace OneSkyDotNet
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    internal class OneSky
    {
        private readonly string authenticationApiKey = "api_key";

        private readonly string authenticationTimestamp = "timestamp";

        private readonly string authenticationDevHash = "dev_hash";

        private string publicKey;

        private string secretKey;

        public OneSky(string publicKey, string secretKey)
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

        private OneSkyRequest CreateRequest(string url)
        {
            var timestamp = this.Timestamp;
            var devHash = this.GetDevHash(timestamp);

            this.RequestCount++;

            return
                (new OneSkyRequest(url)).Parameter(this.authenticationApiKey, this.publicKey)
                    .Parameter(this.authenticationTimestamp, timestamp)
                    .Parameter(this.authenticationDevHash, devHash);
        }
    }
}