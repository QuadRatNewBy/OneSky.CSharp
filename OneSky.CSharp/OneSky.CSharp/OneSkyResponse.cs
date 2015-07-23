namespace OneSky.CSharp
{
    /// <summary>
    /// The OneSky plain response.
    /// </summary>
    internal class OneSkyResponse : IOneSkyResponse
    {
        /// <summary>
        /// HTTP response status code.
        /// </summary>
        public int StatusCode { get; internal set; }

        /// <summary>
        /// HTTP response status description.
        /// </summary>
        public string StatusDescription { get; internal set; }

        /// <summary>
        /// Response body as string.
        /// </summary>
        public string Content { get; internal set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return string.Format("[{0}] {1}\n", this.StatusCode, this.StatusDescription) + this.Content;
        }
    }
}
