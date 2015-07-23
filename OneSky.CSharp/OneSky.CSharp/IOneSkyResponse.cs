namespace OneSky.CSharp
{
    /// <summary>
    /// The OneSky plain response Interface.
    /// </summary>
    public interface IOneSkyResponse
    {
        /// <summary>
        /// HTTP response status code.
        /// </summary>
        int StatusCode { get; }

        /// <summary>
        /// HTTP response status description.
        /// </summary>
        string StatusDescription { get; }
        
        /// <summary>
        /// Response body as string.
        /// </summary>
        string Content { get; }
    }
}