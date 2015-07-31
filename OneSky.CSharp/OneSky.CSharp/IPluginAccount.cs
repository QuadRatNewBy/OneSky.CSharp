namespace OneSky.CSharp
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
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse GetCredit();
    }
}