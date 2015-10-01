namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    /// <summary>
    /// Plugin API Specialization endpoints interface.
    /// </summary>
    public interface IPluginSpecialization
    {
        /// <summary>
        /// Lists all project specializations.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and list of <see cref="ISpecialization"/> as <c>Data</c>.
        /// </returns>
        /// <remarks>
        /// For example, translation of a website about gaming may require longer time than a website about fashion design with similar words count in both sites.
        /// </remarks>
        IOneSkyResponse<IMeta, IEnumerable<ISpecialization>> GetSpecializations();
    }
}