namespace OneSky.CSharp
{
    /// <summary>
    /// Platform API Project Type endpoints interface.
    /// </summary>
    public interface IPlatformProjectType
    {
        /// <summary>
        /// Lists all project types.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse List();
    }
}