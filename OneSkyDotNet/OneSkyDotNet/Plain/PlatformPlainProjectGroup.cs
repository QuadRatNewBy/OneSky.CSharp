namespace OneSkyDotNet
{
    internal class PlatformPlainProjectGroup : IPlatformPlainProjectGroup
    {
        private const string ProjectGroupListAddress = "https://platform.api.onesky.io/1/project-groups";
        private const string ProjectGroupShowAddress = "https://platform.api.onesky.io/1/project-groups/{project_group_id}";
        private const string ProjectGroupCreateAddress = "https://platform.api.onesky.io/1/project-groups";
        private const string ProjectGroupDeleteAddress = "https://platform.api.onesky.io/1/project-groups/{project_group_id}";
        private const string ProjectGroupLanguagesAddress = "https://platform.api.onesky.io/1/project-groups/{project_group_id}/languages";

        private const string ProjectGroupListPageParam = "page";
        private const string ProjectGroupListPerPageParam = "per_page";

        private const string ProjectGroupCreateNameBody = "name";
        private const string ProjectGroupCreateLocaleBody = "locale";

        private const string ProjectGroupIdPlacehoder = "project_group_id";
            
        private OneSky oneSky;

        internal PlatformPlainProjectGroup(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public string List(int page = 1, int perPage = 50)
        {
            return
                this.oneSky.CreateRequest(ProjectGroupListAddress)
                    .Parameter(ProjectGroupListPageParam, page)
                    .Parameter(ProjectGroupListPerPageParam, perPage)
                    .Get();
        }

        public string Show(int projectGroupId)
        {
            return
                this.oneSky.CreateRequest(ProjectGroupShowAddress)
                    .Placeholder(ProjectGroupIdPlacehoder, projectGroupId)
                    .Get();
        }

        public string Create(string name, string locale = "en")
        {
            return
                this.oneSky.CreateRequest(ProjectGroupCreateAddress)
                    .Body(ProjectGroupCreateNameBody, name)
                    .Body(ProjectGroupCreateLocaleBody, locale)
                    .Post();
        }

        public string Delete(int projectGroupId)
        {
            return
                this.oneSky.CreateRequest(ProjectGroupDeleteAddress)
                    .Placeholder(ProjectGroupIdPlacehoder, projectGroupId)
                    .Delete();
        }

        public string Languages(int projectGroupId)
        {
            return
                this.oneSky.CreateRequest(ProjectGroupLanguagesAddress)
                    .Placeholder(ProjectGroupIdPlacehoder, projectGroupId)
                    .Get();
        }
    }
}