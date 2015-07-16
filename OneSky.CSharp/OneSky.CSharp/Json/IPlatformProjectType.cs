namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    public interface IPlatformProjectType
    {
        IOneSkyResponse<IMetaList, IEnumerable<IProjectType>> List();
    }
}