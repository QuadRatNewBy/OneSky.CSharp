namespace OneSkyDotNet.Json
{
    using System;

    using System.Collections.Generic;

    internal class PlatformProject : IPlatformProject
    {
        private OneSkyDotNet.IPlatformProject project;

        internal PlatformProject(OneSkyDotNet.IPlatformProject project)
        {
            this.project = project;
        }

        public IOneSkyResponse<IMetaList, IEnumerable<IProject>> List(int projectGroupId)
        {
            var plain = this.project.List(projectGroupId);
            return JsonHelper.PlatformCompose<IMetaList, IEnumerable<IProject>, MetaList, List<Project>>(plain);
        }

        public IOneSkyResponse<IMeta, IProjectDetails> Show(int projectId)
        {
            var plain = this.project.Show(projectId);
            return JsonHelper.PlatformCompose<IMeta, IProjectDetails, Meta, ProjectDetails>(plain);
        }

        public IOneSkyResponse<IMeta, IProjectNew> Create(int projectGroupId, string projectType, string name = null, string description = null)
        {
            var plain = this.project.Create(projectGroupId, projectType, name, description);
            return JsonHelper.PlatformCompose<IMeta, IProjectNew, Meta, ProjectNew>(plain);
        }

        public IOneSkyResponse<IMeta, INull> Update(int projectId, string name = null, string description = null)
        {
            var plain = this.project.Update(projectId, name, description);
            return JsonHelper.PlatformCompose<IMeta, INull, Meta, Null>(plain);
        }

        public IOneSkyResponse<IMeta, INull> Delete(int projectId)
        {
            var plain = this.project.Delete(projectId);
            return JsonHelper.PlatformCompose<IMeta, INull, Meta, Null>(plain);
        }

        public IOneSkyResponse<IMetaList, IEnumerable<ILocaleProject>> Languages(int projectId)
        {
            var plain = this.project.Languages(projectId);
            return JsonHelper.PlatformCompose<IMetaList, IEnumerable<ILocaleProject>, MetaList, List<LocaleProject>>(plain);
        }
    }
}
