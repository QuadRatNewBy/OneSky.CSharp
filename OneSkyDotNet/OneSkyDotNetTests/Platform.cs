namespace OneSkyDotNetTests
{
    using System;
    using System.Linq;
    using System.Text;

    using FluentAssertions;

    using Xunit;

    public class Platform
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

        private OneSkyDotNet.Json.IPlatform platform =
            OneSkyDotNet.Json.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Platform;

        private string projectGroupLocale = "be";

        private string projectGroupName;

        private int projectGroupId;

        private int projectGroupId2;

        private int projectId;

        private string projectName;

        [Fact]
        public void GrandTest()
        {
            this.ProjectGroupCreate();
            this.ProjectGroupCreateFake();
            this.ProjectGroupList();
            this.ProjectGroupListMeta();
            this.ProjectGroupShowFresh();
            this.ProjectGroupLanguagesFresh();

            this.ProjectCreate();
            this.ProjectListFresh();
            this.ProjectUpdate();
            this.ProjectShowFresh();
            this.ProjectLanguageFresh();

            // Cleanup
            this.ProjectDelete();
            this.ProjectGroupDeleteFake();
            this.ProjectGroupDelete();
        }

        public void ProjectGroupCreate()
        {
            this.projectGroupName = this.RandomString(32);

            var response = this.platform.ProjectGroup.Create(this.projectGroupName, this.projectGroupLocale);

            response.MetaContent.Status.Should().Be(201, "[Documentation]").And.Be(response.StatusCode);

            response.DataContent.Name.Should().StartWith(this.projectGroupName, "[Created that way]");
            response.DataContent.BaseLanguage.Should().NotBeNull();
            response.DataContent.BaseLanguage.Locale.Should().Be(this.projectGroupLocale, "[Created that way]");

            this.projectGroupId = response.DataContent.Id;
        }

        public void ProjectGroupCreateFake()
        {
            var response = this.platform.ProjectGroup.Create(this.RandomString(16));

            response.MetaContent.Status.Should().Be(201, "[Documentation]").And.Be(response.StatusCode);
            
            response.DataContent.BaseLanguage.Should().NotBeNull();
            response.DataContent.BaseLanguage.Locale.Should().Be("en", "[As Default]");

            this.projectGroupId2 = response.DataContent.Id;
        }

        public void ProjectGroupList()
        {
            var perPage = 100;
            var response = this.platform.ProjectGroup.List(1, perPage);

            response.MetaContent.Status.Should().Be(200, "[Documentation]").And.Be(response.StatusCode);

            response.DataContent.Should()
                .NotBeNullOrEmpty("We've created 2 Project Groups by now")
                .And.HaveCount(response.MetaContent.RecordCount)
                .And.Contain(x => x.Id == this.projectGroupId2, "we created 'fake' project group")
                .And.Contain(x => x.Name.StartsWith(this.projectGroupName));
        }

        public void ProjectGroupListMeta()
        {
            var perPage = 1;
            var response1 = this.platform.ProjectGroup.List(1, perPage);
            var response2 = this.platform.ProjectGroup.List(2, perPage);

            response1.MetaContent.FirstPage.Should()
                .NotBeNullOrWhiteSpace("First page always exists")
                .And.Be(response2.MetaContent.FirstPage);

            response2.MetaContent.LastPage.Should()
                .NotBeNullOrWhiteSpace("Last page always exists")
                .And.Be(response1.MetaContent.LastPage)
                .And.NotBe(
                    response1.MetaContent.FirstPage,
                    "We created 2 Project Groups but displaying 1 per page. There should definitrly be more that one page");

            response1.MetaContent.NextPage.Should().NotBeNullOrWhiteSpace();
            response2.MetaContent.PreviousPage.Should().NotBeNullOrWhiteSpace();
        }

        public void ProjectGroupShowFresh()
        {
            var response = this.platform.ProjectGroup.Show(this.projectGroupId);

            response.MetaContent.Status.Should().Be(200, "[Documentation]").And.Be(response.StatusCode);

            response.DataContent.Name.Should().StartWith(this.projectGroupName);
            response.DataContent.EnabledLanguageCount.Should().Be(1, "Only language set during creation");
            response.DataContent.ProjectCount.Should().Be(0, "We have not created projects yet");
        }

        public void ProjectGroupLanguagesFresh()
        {
            var response = this.platform.ProjectGroup.Languages(this.projectGroupId);

            response.MetaContent.Status.Should().Be(200, "[Documentation]").And.Be(response.StatusCode);

            response.DataContent.Should()
                .HaveCount(response.MetaContent.RecordCount)
                .And.HaveCount(1, "Clean start - only one language")
                .And.Contain(x => x.Locale == this.projectGroupLocale, "We created this locale")
                .And.ContainSingle(x => x.IsBaseLanguage, "One base language");
        }

        public void ProjectCreate() 
        {
            this.projectName = RandomString(32);

            var projectType = this.platform.ProjectType.List().DataContent.First(x=>x.Code.EndsWith("-others"));

            var response = this.platform.Project.Create(this.projectGroupId, projectType.Code, this.projectName);

            response.StatusCode.Should().Be(201);

            response.DataContent.Name.Should().Be(this.projectName);
            response.DataContent.ProjectType.Name.Should().Be(projectType.Name);            
            response.DataContent.ProjectType.Code.Should().Be(projectType.Code);
            response.DataContent.Description.Should().BeNullOrWhiteSpace("Created without description");

            this.projectId = response.DataContent.Id;
        }

        public void ProjectListFresh() 
        {
            var response = this.platform.Project.List(this.projectGroupId);

            response.DataContent.Should().HaveCount(response.MetaContent.RecordCount)
                .And.Contain(x => x.Id == this.projectId)
                .And.Contain(x => x.Name == this.projectName);
        }

        public void ProjectUpdate() 
        {
            var response = this.platform.Project.Update(this.projectId, this.projectName, "TestDesc");
            response.StatusCode.Should().Be(200);                        
        }

        public void ProjectShowFresh() 
        {
            var response = this.platform.Project.Show(this.projectId);

            response.DataContent.Name.Should().Be(this.projectName);
            response.DataContent.Description.Should().Be("TestDesc");
            response.DataContent.ProjectType.Code.Should().EndWith("-others");
        }

        public void ProjectLanguageFresh() 
        {
            var response = this.platform.Project.Languages(this.projectId);

            response.DataContent.Should()
                .HaveCount(response.MetaContent.RecordCount)
                .And.HaveCount(1, "Clean start - only one language")
                .And.Contain(x => x.Locale == this.projectGroupLocale, "We created this locale")
                .And.ContainSingle(x => x.IsBaseLanguage, "One base language");
        }

        // Cleaning up
        public void ProjectDelete()
        {
            var response = this.platform.Project.Delete(this.projectId);
            response.StatusCode.Should().Be(200);
        }

        public void ProjectGroupDeleteFake()
        {
            var response = this.platform.ProjectGroup.Delete(this.projectGroupId2);
            response.StatusCode.Should().Be(200);
        }

        public void ProjectGroupDelete()
        {
            var response = this.platform.ProjectGroup.Delete(this.projectGroupId);
            response.StatusCode.Should().Be(200);
        }
    }
}