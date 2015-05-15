namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class PlatformProjectGroup : IPlatformProjectGroup
    {
        private readonly OneSkyDotNet.IPlatformProjectGroup projectGroup;

        public PlatformProjectGroup(OneSkyDotNet.IPlatformProjectGroup projectGroup)
        {
            this.projectGroup = projectGroup;
        }

        public IOneSkyResponse<IMetaPagedList, IEnumerable<IProjectGroup>> List(int page = 1, int perPage = 50)
        {
            var plain = this.projectGroup.List(page, perPage);
            return JsonHelper.PlatformCompose<IMetaPagedList, IEnumerable<IProjectGroup>, MetaPagedList, List<ProjectGroup>>(plain);
        }

        public IOneSkyResponse<IMeta, IProjectGroupDetails> Show(int projectGroupId)
        {
            var plain = this.projectGroup.Show(projectGroupId);
            return JsonHelper.PlatformCompose<IMeta, IProjectGroupDetails, Meta, ProjectGroupDetails>(plain);
        }

        public IOneSkyResponse<IMeta, IProjectGroupNew> Create(string name, string locale = "en")
        {
            var plain = this.projectGroup.Create(name, locale);
            return JsonHelper.PlatformCompose<IMeta, IProjectGroupNew, Meta, ProjectGroupNew>(plain);
        }

        public IOneSkyResponse<string, string> Delete(int projectGroupId)
        {
            var plain = this.projectGroup.Delete(projectGroupId);
            return new OneSkyResponse<string, string>(
                plain.StatusCode,
                plain.StatusDescription,
                string.Empty,
                string.Empty);
        }

        public IOneSkyResponse<IMetaList, IEnumerable<ILocaleGroup>> Languages(int projectGroupId)
        {
            var plain = this.projectGroup.Languages(projectGroupId);
            return JsonHelper.PlatformCompose<IMetaList, IEnumerable<ILocaleGroup>, MetaList, List<LocaleGroup>>(plain);
        }
    }
}