namespace OneSky.CSharp
{
    /// <summary>
    /// Plugin API Project endpoints interface.
    /// </summary>
    public interface IPluginProject
    {
        /// <summary>
        /// Retrieve all projects of specified platform.
        /// </summary>
        /// <param name="platform">
        /// <para>Platform of projects.</para>
        /// <para>Currently only support <c>magento</c>.</para>
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse GetProjects(string platform = "magento");

        /// <summary>
        /// Create project of specified platform.
        /// </summary>
        /// <param name="name">
        /// Name of the project.
        /// </param>
        /// <param name="platform">
        /// <para>Platform of projects.</para>
        /// <para>Currently only support <c>magento</c>.</para>
        /// </param>
        /// <param name="locale">
        /// Base language of the project.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        IOneSkyResponse PostProject(string name, string platform = "magento", string locale = null);
    }
}