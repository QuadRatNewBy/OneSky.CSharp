namespace OneSky.CSharp
{
    /// <summary>
    /// Plugin API Specialization endpoints interface.
    /// </summary>
    public interface IPluginSpecialization
    {
        /// <summary>
        /// Lists all project specializations.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        /// <remarks>
        /// For example, translation of a website about gaming may require longer time than a website about fashion design with similar words count in both sites.
        /// </remarks>
        IOneSkyResponse GetSpecializations();
    }
}