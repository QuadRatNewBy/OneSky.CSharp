namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    /// <summary>
    /// Platform API Project Type endpoints interface.
    /// </summary>
    public interface IPlatformProjectType
    {
        /// <summary>
        /// Lists all project types.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMetaList"/> as <c>Meta</c> and list of <see cref="IProjectType"/> as <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMetaList, IEnumerable<IProjectType>> List();
    }
}