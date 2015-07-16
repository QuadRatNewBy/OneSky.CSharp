namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    internal class PlatformProjectType : IPlatformProjectType
    {
        private CSharp.IPlatformProjectType projectType;

        public PlatformProjectType(CSharp.IPlatformProjectType projectType)
        {
            this.projectType = projectType;
        }

        public IOneSkyResponse<IMetaList, IEnumerable<IProjectType>> List()
        {
            var plain = this.projectType.List();
            return JsonHelper.PlatformCompose<IMetaList, IEnumerable<IProjectType>, MetaList, List<ProjectType>>(plain);
        }
    }
}