namespace OneSky.CSharp
{
    internal class PlatformProject : IPlatformProject
    {
        private const string ProjectListAddress =
            "https://platform.api.onesky.io/1/project-groups/{project_group_id}/projects";

        private const string ProjectShowAddress = "https://platform.api.onesky.io/1/projects/{project_id}";

        private const string ProjectCreateAddress =
            "https://platform.api.onesky.io/1/project-groups/{project_group_id}/projects";

        private const string ProjectUpdateAddress = "https://platform.api.onesky.io/1/projects/{project_id}";

        private const string ProjectDeleteAddress = "https://platform.api.onesky.io/1/projects/{project_id}";

        private const string ProjectLanguagesAddress =
            "https://platform.api.onesky.io/1/projects/{project_id}/languages";

        private const string ProjectCreateProjectTypeBody = "project_type";

        private const string ProjectCreateNameBody = "name";

        private const string ProjectCreateDescriptionBody = "description";

        private const string ProjectUpdateNameBody = "name";

        private const string ProjectUpdateDescriptionBody = "description";

        private const string ProjectGroupIdPlaceholder = "project_group_id";

        private const string ProjectIdPlaceholder = "project_id";

        private OneSkyHelper oneSky;

        internal PlatformProject(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse List(int projectGroupId)
        {
            return
                this.oneSky.CreateRequest(ProjectListAddress)
                    .Placeholder(ProjectGroupIdPlaceholder, projectGroupId)
                    .Get();
        }

        public IOneSkyResponse Show(int projectId)
        {
            return this.oneSky.CreateRequest(ProjectShowAddress).Placeholder(ProjectIdPlaceholder, projectId).Get();
        }

        public IOneSkyResponse Create(
            int projectGroupId,
            string projectType,
            string name = null,
            string description = null)
        {
            return
                this.oneSky.CreateRequest(ProjectCreateAddress)
                    .Placeholder(ProjectGroupIdPlaceholder, projectGroupId)
                    .Body(ProjectCreateProjectTypeBody, projectType)
                    .Body(ProjectCreateNameBody, name, name != null)
                    .Body(ProjectCreateDescriptionBody, description, description != null)
                    .Post();
        }

        public IOneSkyResponse Update(int projectId, string name = null, string description = null)
        {
            return
                this.oneSky.CreateRequest(ProjectUpdateAddress)
                    .Placeholder(ProjectIdPlaceholder, projectId)
                    .Body(ProjectUpdateNameBody, name, name != null)
                    .Body(ProjectUpdateDescriptionBody, description, description != null)
                    .Put();
        }

        public IOneSkyResponse Delete(int projectId)
        {
            return this.oneSky.CreateRequest(ProjectDeleteAddress).Placeholder(ProjectIdPlaceholder, projectId).Delete();
        }

        public IOneSkyResponse Languages(int projectId)
        {
            return this.oneSky.CreateRequest(ProjectLanguagesAddress).Placeholder(ProjectIdPlaceholder, projectId).Get();
        }
    }
}