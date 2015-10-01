namespace OneSky.CSharp.Json
{
    /// <summary>
    /// Plugin API Account endpoints interface.
    /// </summary>
    public interface IPluginAccount : IPluginAnonymous
    {
        /// <summary>
        /// Retrieve account remaining credit.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and <see cref="IAccountCredit"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, IAccountCredit> GetCredit();
    }
}