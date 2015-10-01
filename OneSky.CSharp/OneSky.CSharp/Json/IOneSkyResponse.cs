namespace OneSky.CSharp.Json
{
    /// <summary>
    /// The OneSky Deserialized-JSON response Interface.
    /// </summary>
    /// <typeparam name="TMeta">
    /// Type of Meta in response.
    /// </typeparam>
    /// <typeparam name="TData">
    /// Type of Data in response.
    /// </typeparam>
    public interface IOneSkyResponse<out TMeta, out TData>
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
        /// Response Meta.
        /// </summary>
        TMeta Meta { get; }
        
        /// <summary>
        /// Response Data.
        /// </summary>
        TData Data { get; }
    }
}
