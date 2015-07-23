namespace OneSky.CSharp
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    /// <summary>
    /// OneSky helper. Hides Authentication details. 
    /// </summary>
    internal class OneSkyHelper
    {
        /// <summary>
        /// The authentication API key.
        /// </summary>
        private const string AuthenticationApiKey = "api_key";

        /// <summary>
        /// The authentication timestamp.
        /// </summary>
        private const string AuthenticationTimestamp = "timestamp";

        /// <summary>
        /// The authentication DEV hash.
        /// </summary>
        private const string AuthenticationDevHash = "dev_hash";

        /// <summary>
        /// The public key.
        /// </summary>
        private readonly string publicKey;

        /// <summary>
        /// The secret key.
        /// </summary>
        private readonly string secretKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneSkyHelper"/> class.
        /// </summary>
        /// <param name="publicKey">
        /// The public key.
        /// </param>
        /// <param name="secretKey">
        /// The secret key.
        /// </param>
        internal OneSkyHelper(string publicKey, string secretKey)
        {
            this.publicKey = publicKey;
            this.secretKey = secretKey;
        }

        /// <summary>
        /// Gets the request count.
        /// </summary>
        internal int RequestCount { get; private set; }

        /// <summary>
        /// Gets the timestamp in UNIX fashion.
        /// </summary>
        private int Timestamp
        {
            get
            {
                var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                var diff = DateTime.UtcNow - origin;
                return (int)Math.Floor(diff.TotalSeconds);
            }
        }

        /// <summary>
        /// Creates <see cref="OneSkyRequest"/> without authentication data.
        /// </summary>
        /// <param name="url">
        /// The url of request.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyRequest"/>.
        /// </returns>
        internal static OneSkyRequest CreateAnonymousRequest(string url)
        {
            return new OneSkyRequest(url);
        }

        /// <summary>
        /// Creates <see cref="OneSkyRequest"/> with embedded authentication data.
        /// </summary>
        /// <param name="url">
        /// The url of request.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyRequest"/>.
        /// </returns>
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

        /// <summary>
        /// The get DEV hash.
        /// </summary>
        /// <param name="timestamp">
        /// Current UNIX timestamp.
        /// </param>
        /// <returns>
        /// DEV hash for authentication.
        /// </returns>
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
    }
}