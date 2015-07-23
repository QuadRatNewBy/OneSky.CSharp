namespace OneSky.CSharp
{
    /// <summary>
    /// The OneSkyRequest helper interface. Hides details of HTTP requests.
    /// </summary>
    internal interface IOneSkyRequest
    {
        /// <summary>
        /// Replaces placeholder like <c>{placeholder}</c> in request url.
        /// </summary>
        /// <param name="placeholder">
        /// Placeholder to replace (without curly brackets).
        /// </param>
        /// <param name="value">
        /// Value to insert.
        /// </param>
        /// <param name="condition">
        /// Replacement condition (resolved).
        /// </param>
        /// <returns>
        /// Same <see cref="IOneSkyRequest"/> instance.
        /// </returns>
        IOneSkyRequest Placeholder(string placeholder, object value, bool condition = true);

        /// <summary>
        /// Appends parameter to url (like parameter=value).
        /// </summary>
        /// <param name="parameter">
        /// Parameter name.
        /// </param>
        /// <param name="value">
        /// Parameter value.
        /// </param>
        /// <param name="condition">
        /// Appending condition (resolved).
        /// </param>
        /// <returns>
        /// Same <see cref="IOneSkyRequest"/> instance.
        /// </returns>
        IOneSkyRequest Parameter(string parameter, object value, bool condition = true);

        /// <summary>
        /// Adds new object to request body.
        /// </summary>
        /// <param name="key">
        /// Object key.
        /// </param>
        /// <param name="value">
        /// Object value.
        /// </param>
        /// <param name="condition">
        /// Adding condition (resolved).
        /// </param>
        /// <returns>
        /// Same <see cref="IOneSkyRequest"/> instance.
        /// </returns>
        IOneSkyRequest Body(string key, object value, bool condition = true);

        /// <summary>
        /// Adds file to request body.
        /// </summary>
        /// <param name="name">
        /// File name.
        /// </param>
        /// <param name="path">
        /// Path to file.
        /// </param>
        /// <param name="condition">
        /// Adding condition (resolved).
        /// </param>
        /// <returns>
        /// Same <see cref="IOneSkyRequest"/> instance.
        /// </returns>
        IOneSkyRequest Files(string name, string path, bool condition = true);

        /// <summary>
        /// Sends <c>GET</c> request.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/> response.
        /// </returns>
        IOneSkyResponse Get();

        /// <summary>
        /// Sends <c>POST</c> request.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/> response.
        /// </returns>
        IOneSkyResponse Post();

        /// <summary>
        /// Sends <c>PUT</c> request.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/> response.
        /// </returns>
        IOneSkyResponse Put();

        /// <summary>
        /// Sends <c>DELETE</c> request.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/> response.
        /// </returns>
        IOneSkyResponse Delete();
    }
}
