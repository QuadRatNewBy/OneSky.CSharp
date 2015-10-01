namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    /// <summary>
    /// Platform API Screenshot endpoints interface.
    /// </summary>
    public interface IPlatformScreenshot
    {
        /// <summary>
        /// Uploads a screenshot to specific project.
        /// </summary>
        /// <param name="projectId">
        /// Id of the project.
        /// </param>
        /// <param name="screenshots">
        /// List of <see cref="IScreenshot"/>.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse{TMeta,TData}"/> with <see cref="IMeta"/> as <c>Meta</c> and no <c>Data</c>.
        /// </returns>
        IOneSkyResponse<IMeta, INull> Upload(int projectId, IEnumerable<IScreenshot> screenshots);
    }
}