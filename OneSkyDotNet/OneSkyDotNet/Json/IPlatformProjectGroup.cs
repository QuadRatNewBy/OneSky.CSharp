namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IPlatformProjectGroup
    {
        IOneSkyResponse<IMetaPagedList, IEnumerable<IProjectGroup>> List(int page = 1, int perPage = 50);

        IOneSkyResponse<IMeta, IProjectGroupDetails> Show(int projectGroupId);

        IOneSkyResponse<IMeta, IProjectGroupNew> Create(string name, string locale = "en");

        IOneSkyResponse<IMeta, INull> Delete(int projectGroupId);

        IOneSkyResponse<IMetaList, IEnumerable<ILocaleGroup>> Languages(int projectGroupId); 
    }
}