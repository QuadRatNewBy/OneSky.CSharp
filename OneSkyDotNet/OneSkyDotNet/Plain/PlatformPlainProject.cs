namespace OneSkyDotNet
{
    internal class PlatformPlainProject : IPlatformPlainProject
    {
        private const string ProjectListAddress = "https://platform.api.onesky.io/1/project-groups/{project_group_id}/projects";
        private const string ProjectShowAddress = "https://platform.api.onesky.io/1/projects/{project_id}";
        private const string ProjectCreateAddress = "https://platform.api.onesky.io/1/project-groups/{project_group_id}/projects";
        private const string ProjectUpdateAddress = "https://platform.api.onesky.io/1/projects/{project_id}";
        private const string ProjectDeleteAddress = "https://platform.api.onesky.io/1/projects/{project_id}";
        private const string ProjectLanguagesAddress = "https://platform.api.onesky.io/1/projects/{project_id}/languages";
        
        private const string ProjectCreateProjectTypeBody = "project_type";
        private const string ProjectCreateNameBody = "name";
        private const string ProjectCreateDescriptionBody = "description";

        private const string ProjectGroupIdPlacehoder = "project_group_id";
        private const string ProjectIdPlacehoder = "project_id";

        private OneSky oneSky;

        internal PlatformPlainProject(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public string List(int projectGroupId)
        {
            return
                this.oneSky.CreateRequest(ProjectListAddress)
                    .Placeholder(ProjectGroupIdPlacehoder, projectGroupId)
                    .Get();
        }

        public string Show(int projectId)
        {
            return this.oneSky.CreateRequest(ProjectShowAddress).Placeholder(ProjectIdPlacehoder, projectId).Get();
        }

        public string Create(int projectGroupId, string projectType, string name = null, string description = null)
        {
            return
                this.oneSky.CreateRequest(ProjectCreateAddress)
                    .Placeholder(ProjectGroupIdPlacehoder, projectGroupId)
                    .Body(ProjectCreateProjectTypeBody, projectType)
                    .Body(ProjectCreateNameBody, name, name != null)
                    .Body(ProjectCreateDescriptionBody, description, description != null)
                    .Post();
        }

        public string Update(int projectId, string name = null, string description = null)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(int projectId)
        {
            throw new System.NotImplementedException();
        }

        public string Languages(int projectId)
        {
            throw new System.NotImplementedException();
        }
    }
}