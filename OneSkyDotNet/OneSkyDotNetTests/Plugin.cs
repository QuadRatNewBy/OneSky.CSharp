namespace OneSkyDotNetTests
{
    using System;
    using System.Linq;
    using System.Text;

    using FluentAssertions;

    using Xunit;

    public class Plugin
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        private OneSkyDotNet.Json.IPlugin plugin =
            OneSkyDotNet.Json.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Plugin;

        private string projectLocale = "be";

        private string projectName;

        private int projectId;

        private int projectId2;

        [Fact]
        public void GrandTest()
        {
            this.ProjectCreate();
            this.ProjectCreateFake();
            this.ProjectList();
        }

        public void ProjectCreate() 
        {
            this.projectName = RandomString(32);

            var response = this.plugin.Project.PostProject(this.projectName, locale: this.projectLocale);

            response.DataContent.Name.Should().StartWith(this.projectName);
            response.DataContent.BaseLanguage.Locale.Should().Be(this.projectLocale);

            this.projectId = response.DataContent.Id;
        }

        public void ProjectCreateFake() 
        {
            var name = RandomString(16);
            var response = this.plugin.Project.PostProject(name);

            response.DataContent.Name.Should().StartWith(name);
            response.DataContent.BaseLanguage.Locale.Should().Be("en");

            this.projectId2 = response.DataContent.Id;
        }

        public void ProjectList()
        {
            var response = this.plugin.Project.GetProjects();

            response.DataContent.Should().Contain(x => x.Id == this.projectId2)
                .And.Contain(x => x.Name.StartsWith(this.projectName));
        }
    }
}
