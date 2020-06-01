using System;

namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    /// <summary>
    /// Plugin API Anonymous Account endpoints (i.e. accessible without API keys) interface.
    /// </summary>
    public interface IPluginAnonymous
    {
        /// <summary>
        /// Register account in OneSky.
        /// </summary>
        /// <param name="email">
        /// User Email to register account.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and no <c>Data</c>.
        /// </returns>
        /// <remarks>
        /// Password will be sent to Email specified in <paramref name="email"/> parameter.
        /// </remarks>
        IOneSkyResponse<IMeta, INull> SignUp(string email);

        /// <summary>
        /// Login to OneSky account.
        /// </summary>
        /// <param name="email">
        /// User email.
        /// </param>
        /// <param name="password">
        /// Account password.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and list of <see cref="IAccount"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IEnumerable<IAccount>> SignIn(string email, string password);

        /// <summary>
        /// Register account in OneSky.
        /// </summary>
        /// <param name="email">
        /// User Email to register account.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and no <c>Data</c>.
        /// </returns>
        /// <remarks>
        /// Password will be sent to Email specified in <paramref name="email"/> parameter.
        /// </remarks>
        [Obsolete("'Sign' is misspelled as 'Sing'. Will be removed in 2.0", false)]
        IOneSkyResponse<IMeta, INull> SingUp(string email);

        /// <summary>
        /// Login to OneSky account.
        /// </summary>
        /// <param name="email">
        /// User email.
        /// </param>
        /// <param name="password">
        /// Account password.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and list of <see cref="IAccount"/> as <c>Data</c>.
        /// </returns>
        [Obsolete("'Sign' is misspelled as 'Sing'. Will be removed in 2.0", false)]
        IOneSkyResponse<IMeta, IEnumerable<IAccount>> SingIn(string email, string password);
    }
}