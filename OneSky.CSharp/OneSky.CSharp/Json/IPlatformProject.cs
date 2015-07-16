namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    public interface IPlatformProject
    {
        IOneSkyResponse<IMetaList, IEnumerable<IProject>> List(int projectGroupId);

        IOneSkyResponse<IMeta, IProjectDetails> Show(int projectId);

        IOneSkyResponse<IMeta, IProjectNew> Create(int projectGroupId, string projectType, string name = null, string description = null);

        IOneSkyResponse<IMeta, INull> Update(int projectId, string name = null, string description = null);

        IOneSkyResponse<IMeta, INull> Delete(int projectId);

        IOneSkyResponse<IMetaList, IEnumerable<ILocaleProject>> Languages(int projectId);
    }
}
