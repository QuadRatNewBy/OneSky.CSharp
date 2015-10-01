namespace OneSky.CSharp
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
        /// List of screenshots (JSON serialized).
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse Upload(int projectId, IEnumerable<string> screenshots);
    }
}